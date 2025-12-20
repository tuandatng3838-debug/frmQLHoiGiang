using System.Linq;
using FrmQLHoiGiang.Models;
using FrmQLHoiGiang.Services;
using FrmQLHoiGiang.Ui;
using Siticone.Desktop.UI.WinForms;

namespace FrmQLHoiGiang.Controls;

public partial class UcSangKien : UserControl
{
    private readonly BindingSource _binding = new();
    private List<SangKien> _data = new();
    private List<GiangVien> _giangVien = new();
    private SangKien? _current;

    public UcSangKien()
    {
        InitializeComponent();
        gridSangKien.AutoGenerateColumns = false;
        gridSangKien.DataSource = _binding;
        LoadLookups();
        cboGiangVien.SelectedIndexChanged += (_, _) => UpdateGiangVienInfo();
        LoadData();
        AppServices.GiangVien.Changed += HandleGiangVienChanged;
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        dialog.Parent = FindForm();
    }

    private void LoadLookups()
    {
        _giangVien = AppServices.GiangVien.GetGiangVien();
        cboGiangVien.DataSource = _giangVien.ToList();
        cboGiangVien.DisplayMember = "HoTen";
        cboGiangVien.ValueMember = "GiangVienId";
    }

    private void HandleGiangVienChanged()
    {
        var selectedId = GetSelectedId(cboGiangVien);
        LoadLookups();
        if (selectedId.HasValue)
        {
            cboGiangVien.SelectedValue = selectedId.Value;
        }

        UpdateGiangVienInfo();
    }

    private static int? GetSelectedId(ComboBox combo)
    {
        if (combo.SelectedValue == null)
        {
            return null;
        }

        if (combo.SelectedValue is int value)
        {
            return value;
        }

        return int.TryParse(combo.SelectedValue.ToString(), out var parsed) ? parsed : null;
    }

    private void LoadData()
    {
        _data = AppServices.SangKien.GetAll();
        _binding.DataSource = _data;
        ClearForm();
    }

    private void ClearForm()
    {
        _current = null;
        txtTenSangKien.Text = string.Empty;
        cboTuCach.SelectedIndex = 0;
        cboLoai.SelectedIndex = 0;
        txtLinhVuc.Text = string.Empty;
        txtNamHoc.Text = DateTime.Now.Year.ToString();
        txtThoiGian.Text = string.Empty;
        txtDiaDiem.Text = string.Empty;
        cboXepLoai.SelectedIndex = -1;
        btnHuy.Visible = false;
        btnLuu.FillColor = Color.FromArgb(31, 122, 224);
        btnLuu.Text = "Thêm mới";
        UpdateGiangVienInfo();
    }

    private void gridSangKien_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= _data.Count)
        {
            return;
        }

        _current = _data[e.RowIndex];
        txtTenSangKien.Text = _current.TenSangKien;
        cboGiangVien.SelectedValue = _current.GiangVienId;
        cboTuCach.SelectedItem = _current.TuCach;
        cboLoai.SelectedItem = _current.Loai;
        txtLinhVuc.Text = _current.LinhVuc ?? string.Empty;
        txtNamHoc.Text = _current.NamHoc;
        txtThoiGian.Text = _current.ThoiGianThucHien ?? string.Empty;
        txtDiaDiem.Text = _current.DiaDiemPhamVi ?? string.Empty;
        cboXepLoai.SelectedItem = _current.XepLoai;
        btnHuy.Visible = true;
        btnLuu.FillColor = Color.SeaGreen;
        btnLuu.Text = "Cập nhật";
        UpdateGiangVienInfo();
    }

    private void UpdateGiangVienInfo()
    {
        if (cboGiangVien.SelectedValue is not int id)
        {
            txtGiangVienEmail.Text = string.Empty;
            txtGiangVienDienThoai.Text = string.Empty;
            txtGiangVienNgaySinh.Text = string.Empty;
            return;
        }

        var gv = _giangVien.FirstOrDefault(item => item.GiangVienId == id);
        if (gv == null)
        {
            txtGiangVienEmail.Text = string.Empty;
            txtGiangVienDienThoai.Text = string.Empty;
            txtGiangVienNgaySinh.Text = string.Empty;
            return;
        }

        txtGiangVienEmail.Text = gv.Email ?? string.Empty;
        txtGiangVienDienThoai.Text = gv.SoDienThoai ?? string.Empty;
        txtGiangVienNgaySinh.Text = FormatNgaySinh(gv.NgaySinh);
    }

    private static string FormatNgaySinh(DateTime ngaySinh)
    {
        return ngaySinh == default ? string.Empty : ngaySinh.ToString("dd/MM/yyyy");
    }

    private void ShowMessage(string message, MessageDialogIcon icon = MessageDialogIcon.Warning)
    {
        var mapped = MessageBoxIcon.Warning;
        if (icon == MessageDialogIcon.Information)
        {
            mapped = MessageBoxIcon.Information;
        }
        else if (icon == MessageDialogIcon.Error)
        {
            mapped = MessageBoxIcon.Error;
        }

        MessageBox.Show(FindForm(), message, "Thong bao", MessageBoxButtons.OK, mapped);
    }
private void btnLamMoi_Click(object sender, EventArgs e)
    {
        LoadData();
    }

    private void btnHuy_Click(object sender, EventArgs e)
    {
        ClearForm();
    }

    private void btnLuu_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtTenSangKien.Text) || cboGiangVien.SelectedValue == null)
        {
            ShowMessage("Nhap ten sang kien va chon giang vien.");
            return;
        }

        var entity = _current ?? new SangKien();
        entity.TenSangKien = txtTenSangKien.Text.Trim();
        entity.GiangVienId = (int)cboGiangVien.SelectedValue;
        entity.TuCach = cboTuCach.SelectedItem?.ToString() ?? "Tác giả";
        entity.Loai = cboLoai.SelectedItem?.ToString() ?? "Sáng kiến";
        entity.LinhVuc = txtLinhVuc.Text.Trim();
        entity.NamHoc = txtNamHoc.Text.Trim();
        entity.ThoiGianThucHien = txtThoiGian.Text.Trim();
        entity.DiaDiemPhamVi = txtDiaDiem.Text.Trim();
        entity.XepLoai = cboXepLoai.SelectedItem?.ToString();

        try
        {
            AppServices.SangKien.Save(entity);
            LoadData();
        }
        catch (Exception ex)
        {
            ShowMessage($"Khong the luu sang kien: {ex.Message}", MessageDialogIcon.Error);
        }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (_current == null)
        {
            ShowMessage("Chon sang kien can xoa.");
            return;
        }        var confirmed = DialogHelper.Confirm(FindForm(), $"Xoa sang kien {_current.TenSangKien}?");
        if (confirmed)
        {
            AppServices.SangKien.Delete(_current.SangKienId);
            LoadData();
        }
}

    private void panelRight_Paint(object sender, PaintEventArgs e)
    {
        
    }

    private void UcSangKien_Load(object sender, EventArgs e)
    {

    }
}
