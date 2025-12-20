using FrmQLHoiGiang.Models;
using FrmQLHoiGiang.Services;

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
        LoadData();
        AppServices.GiangVien.Changed += HandleGiangVienChanged;
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
    }

    private void btnLuu_Click(object sender, EventArgs e)
    {
        if (cboGiangVien.SelectedValue == null || string.IsNullOrWhiteSpace(txtTenMon.Text))
        {
            dialog.Text = "Chọn giảng viên và nhập tên môn.";
            dialog.Show();
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
            dialog.Text = "Số tiết không hợp lệ.";
            dialog.Show();
            return;
        }

        if (!int.TryParse(txtSiSo.Text, out var siSo))
        {
            dialog.Text = "Sĩ số không hợp lệ.";
            dialog.Show();
            return;
        }

        entity.SoTiet = soTiet;
        entity.SoSinhVien = siSo;

        var result = AppServices.LichGiang.Save(entity);
        if (!result.Success)
        {
            dialog.Text = result.Error ?? "Không thể lưu.";
            dialog.Show();
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
            dialog.Text = "Chọn lịch cần xóa.";
            dialog.Show();
            return;
        }

        var confirm = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog
        {
            Caption = "Xác nhận",
            Text = $"Xóa lịch dạy {_current.TenMon}?",
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
}
