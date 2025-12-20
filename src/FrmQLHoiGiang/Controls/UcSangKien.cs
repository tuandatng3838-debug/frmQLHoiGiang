using FrmQLHoiGiang.Models;
using FrmQLHoiGiang.Services;

namespace FrmQLHoiGiang.Controls;

public partial class UcSangKien : UserControl
{
    private readonly BindingSource _binding = new();
    private List<SangKien> _data = new();
    private SangKien? _current;

    public UcSangKien()
    {
        InitializeComponent();
        gridSangKien.AutoGenerateColumns = false;
        gridSangKien.DataSource = _binding;
        LoadLookups();
        LoadData();
        AppServices.GiangVien.Changed += HandleGiangVienChanged;
    }

    private void LoadLookups()
    {
        var gv = AppServices.GiangVien.GetGiangVien();
        cboGiangVien.DataSource = gv;
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
            dialog.Text = "Nhập tên sáng kiến và chọn giảng viên.";
            dialog.Show();
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
            dialog.Text = $"Không thể lưu sáng kiến: {ex.Message}";
            dialog.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Error;
            dialog.Show();
        }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (_current == null)
        {
            dialog.Text = "Chọn sáng kiến cần xóa.";
            dialog.Show();
            return;
        }

        var confirm = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog
        {
            Caption = "Xác nhận",
            Text = $"Xóa sáng kiến {_current.TenSangKien}?",
            Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.YesNo,
            Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Warning
        };

        if (confirm.Show() == DialogResult.Yes)
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
