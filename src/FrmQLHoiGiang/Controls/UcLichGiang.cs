using System.Linq;
using FrmQLHoiGiang.Models;
using FrmQLHoiGiang.Services;
using Siticone.Desktop.UI.WinForms;

namespace FrmQLHoiGiang.Controls;

public partial class UcLichGiang : UserControl
{
    private readonly BindingSource _binding = new();
    private List<LichGiang> _data = new();
    private LichGiang? _current;
    private List<GiangVien> _giangVien = new();

    public UcLichGiang()
    {
        InitializeComponent();
        gridLichGiang.AutoGenerateColumns = false;
        gridLichGiang.DataSource = _binding;
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

        cboLocGiangVien.DataSource = _giangVien.ToList();
        cboLocGiangVien.DisplayMember = "HoTen";
        cboLocGiangVien.ValueMember = "GiangVienId";
    }

    private void HandleGiangVienChanged()
    {
        var selectedMain = GetSelectedId(cboGiangVien);
        var selectedFilter = GetSelectedId(cboLocGiangVien);

        LoadLookups();

        if (selectedMain.HasValue)
        {
            cboGiangVien.SelectedValue = selectedMain.Value;
        }

        if (selectedFilter.HasValue)
        {
            cboLocGiangVien.SelectedValue = selectedFilter.Value;
        }

        UpdateLichCaNhan();
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
        _data = AppServices.LichGiang.GetAll();
        _binding.DataSource = _data;
        UpdateLichCaNhan();
        ClearForm();
    }

    private void ClearForm()
    {
        _current = null;
        txtNamHoc.Text = $"{DateTime.Now.Year}-{DateTime.Now.Year + 1}";
        txtTenLop.Text = string.Empty;
        txtTenMon.Text = string.Empty;
        cboBuoi.SelectedIndex = 0;
        dtNgayHoc.Value = DateTime.Today;
        txtPhong.Text = string.Empty;
        txtSoTiet.Text = "3";
        txtSiSo.Text = "40";
        btnHuy.Visible = false;
        btnLuu.FillColor = Color.FromArgb(31, 122, 224);
        btnLuu.Text = "Thêm mới";
        UpdateGiangVienInfo();
    }

    private void gridLichGiang_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= _data.Count)
        {
            return;
        }

        _current = _data[e.RowIndex];
        txtNamHoc.Text = _current.NamHoc;
        txtTenLop.Text = _current.TenLop;
        txtTenMon.Text = _current.TenMon;
        cboGiangVien.SelectedValue = _current.GiangVienId;
        cboBuoi.SelectedItem = _current.Buoi;
        dtNgayHoc.Value = _current.NgayHoc;
        txtPhong.Text = _current.PhongHoc ?? string.Empty;
        txtSoTiet.Text = _current.SoTiet.ToString();
        txtSiSo.Text = _current.SoSinhVien?.ToString() ?? "0";

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
        dialog.Caption = "Thong bao";
        dialog.Icon = icon;
        dialog.Text = message;
        dialog.Show();
    }

    private void btnLuu_Click(object sender, EventArgs e)
    {
        if (cboGiangVien.SelectedValue == null || string.IsNullOrWhiteSpace(txtTenMon.Text))
        {
            ShowMessage("Chon giang vien va nhap ten mon.");
            return;
        }

        var entity = _current ?? new LichGiang();
        entity.NamHoc = txtNamHoc.Text.Trim();
        entity.TenLop = txtTenLop.Text.Trim();
        entity.TenMon = txtTenMon.Text.Trim();
        entity.GiangVienId = (int)cboGiangVien.SelectedValue;
        entity.Buoi = cboBuoi.SelectedItem?.ToString() ?? "Sáng";
        entity.NgayHoc = dtNgayHoc.Value.Date;
        entity.PhongHoc = txtPhong.Text.Trim();
        if (!int.TryParse(txtSoTiet.Text, out var soTiet))
        {
            ShowMessage("So tiet khong hop le.");
            return;
        }

        if (!int.TryParse(txtSiSo.Text, out var siSo))
        {
            ShowMessage("Si so khong hop le.");
            return;
        }

        entity.SoTiet = soTiet;
        entity.SoSinhVien = siSo;

        var result = AppServices.LichGiang.Save(entity);
        if (!result.Success)
        {
            ShowMessage(result.Error ?? "Khong the luu.", MessageDialogIcon.Error);
            return;
        }

        LoadData();
    }

    private void btnHuy_Click(object sender, EventArgs e)
    {
        ClearForm();
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (_current == null)
        {
            ShowMessage("Si so khong hop le.");
            return;
        }

        var confirm = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog
        {
            Caption = "Xác nhận",
            Text = $"Xóa lịch dạy {_current.TenMon}?",
            Parent = FindForm(),
            Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.YesNo,
            Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Warning
        };

        if (confirm.Show() == DialogResult.Yes)
        {
            AppServices.LichGiang.Delete(_current.LichGiangId);
            LoadData();
        }
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
        LoadData();
    }

    private void btnXemLich_Click(object sender, EventArgs e)
    {
        UpdateLichCaNhan();
    }

    private void UpdateLichCaNhan()
    {
        if (cboLocGiangVien.SelectedValue == null)
        {
            return;
        }

        var id = (int)cboLocGiangVien.SelectedValue;
        var lich = _data.Where(l => l.GiangVienId == id)
            .OrderBy(l => l.NgayHoc)
            .ThenBy(l => l.Buoi)
            .Select(l => $"{l.NgayHoc:dd/MM} - {l.Buoi} - {l.TenMon} ({l.TenLop})")
            .ToList();

        lstLichCaNhan.Items.Clear();
        lstLichCaNhan.Items.AddRange(lich.Cast<object>().ToArray());
        lblTongTiet.Text = $"Tổng tiết/năm: {_data.Where(l => l.GiangVienId == id).Sum(l => l.SoTiet)}";
    }

    private void panelRight_Paint(object sender, PaintEventArgs e)
    {

    }

    private void cboLocGiangVien_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
