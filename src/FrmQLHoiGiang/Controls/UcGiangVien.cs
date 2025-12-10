using FrmQLHoiGiang.Models;
using FrmQLHoiGiang.Services;
using Siticone.Desktop.UI.WinForms;

namespace FrmQLHoiGiang.Controls;

public partial class UcGiangVien : UserControl
{
    private const string QueQuanSeparator = "|";
    private readonly BindingSource _binding = new();
    private List<GiangVien> _data = new();
    private GiangVien? _current;

    public UcGiangVien()
    {
        InitializeComponent();
        gridGiangVien.AutoGenerateColumns = false;
        gridGiangVien.DataSource = _binding;
        cboGioiTinh.SelectedIndex = 0;
        LoadLookups();
        LoadData();
    }

    private void LoadLookups()
    {
        cboDonVi.DataSource = AppServices.Lookup.GetDonVi();
        cboDonVi.DisplayMember = "Name";
        cboDonVi.ValueMember = "Id";

        cboTrinhDoCM.DataSource = AppServices.Lookup.GetTrinhDoChuyenMon();
        cboTrinhDoCM.DisplayMember = "Name";
        cboTrinhDoCM.ValueMember = "Id";

        cboTrinhDoLLCT.DataSource = AppServices.Lookup.GetTrinhDoLlct();
        cboTrinhDoLLCT.DisplayMember = "Name";
        cboTrinhDoLLCT.ValueMember = "Id";

        cboCapBac.DataSource = AppServices.Lookup.GetCapBac();
        cboCapBac.DisplayMember = "Name";
        cboCapBac.ValueMember = "Id";

        cboChucDanh.DataSource = AppServices.Lookup.GetChucDanhGiangDay();
        cboChucDanh.DisplayMember = "Name";
        cboChucDanh.ValueMember = "Id";

        cboHocHam.DataSource = AppServices.Lookup.GetHocHam();
        cboHocHam.DisplayMember = "Name";
        cboHocHam.ValueMember = "Id";

        cboHocVi.DataSource = AppServices.Lookup.GetHocVi();
        cboHocVi.DisplayMember = "Name";
        cboHocVi.ValueMember = "Id";
    }

    private void LoadData()
    {
        _data = AppServices.GiangVien.GetGiangVien();
        _binding.DataSource = _data;
        ClearForm();
    }

    private void ClearForm()
    {
        _current = null;
        txtMaSo.Text = string.Empty;
        txtHoTen.Text = string.Empty;
        cboGioiTinh.SelectedIndex = 0;
        dtNgaySinh.Value = DateTime.Today.AddYears(-25);
        txtEmail.Text = string.Empty;
        txtSoDienThoai.Text = string.Empty;
        txtQueQuanXa.Text = string.Empty;
        txtQueQuanTinh.Text = string.Empty;
        txtDanToc.Text = string.Empty;
        txtTonGiao.Text = string.Empty;
        cboTrinhDoCM.SelectedIndex = cboTrinhDoCM.Items.Count > 0 ? 0 : -1;
        cboTrinhDoLLCT.SelectedIndex = cboTrinhDoLLCT.Items.Count > 0 ? 0 : -1;
        cboCapBac.SelectedIndex = cboCapBac.Items.Count > 0 ? 0 : -1;
        txtHeSoLuong.Text = string.Empty;
        cboChucDanh.SelectedIndex = cboChucDanh.Items.Count > 0 ? 0 : -1;
        cboHocHam.SelectedIndex = cboHocHam.Items.Count > 0 ? 0 : -1;
        cboHocVi.SelectedIndex = cboHocVi.Items.Count > 0 ? 0 : -1;
        cboDonVi.SelectedIndex = cboDonVi.Items.Count > 0 ? 0 : -1;
        txtChucVu.Text = string.Empty;
        txtLinhVuc.Text = string.Empty;
        txtNamDayGioi.Text = string.Empty;
        btnHuy.Visible = false;
        btnLuu.FillColor = Color.FromArgb(31, 122, 224);
        btnLuu.Text = "Thêm mới";
    }

    private void gridGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= _data.Count)
        {
            return;
        }

        var entity = _data[e.RowIndex];
        _current = entity;
        txtMaSo.Text = entity.MaSo;
        txtHoTen.Text = entity.HoTen;
        cboGioiTinh.SelectedIndex = entity.GioiTinh ? 1 : 0;
        dtNgaySinh.Value = entity.NgaySinh;
        txtEmail.Text = entity.Email ?? string.Empty;
        txtSoDienThoai.Text = entity.SoDienThoai ?? string.Empty;
        SetQueQuanFields(entity.QueQuan);
        txtDanToc.Text = entity.DanToc ?? string.Empty;
        txtTonGiao.Text = entity.TonGiao ?? string.Empty;
        SelectComboValue(cboTrinhDoCM, entity.TrinhDoCMId);
        SelectComboValue(cboTrinhDoLLCT, entity.TrinhDoLLCTId);
        SelectComboValue(cboCapBac, entity.CapBacId);
        txtHeSoLuong.Text = entity.HeSoLuong?.ToString("0.##") ?? string.Empty;
        SelectComboValue(cboChucDanh, entity.ChucDanhId);
        SelectComboValue(cboHocHam, entity.HocHamId);
        SelectComboValue(cboHocVi, entity.HocViId);
        SelectComboValue(cboDonVi, entity.DonViId);
        txtChucVu.Text = entity.ChucVu ?? string.Empty;
        txtLinhVuc.Text = entity.LinhVucChuyenMon ?? string.Empty;
        txtNamDayGioi.Text = entity.NamGanNhatDayGioi?.ToString() ?? string.Empty;
        btnHuy.Visible = true;
        btnLuu.Text = "Cập nhật";
        btnLuu.FillColor = Color.SeaGreen;
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
        if (string.IsNullOrWhiteSpace(txtMaSo.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
        {
            messageDialog.Text = "Vui lòng nhập Mã số và Họ tên.";
            messageDialog.Show();
            return;
        }

        var entity = _current ?? new GiangVien();
        entity.MaSo = txtMaSo.Text.Trim();
        entity.HoTen = txtHoTen.Text.Trim();
        entity.GioiTinh = cboGioiTinh.SelectedIndex == 1;
        entity.NgaySinh = dtNgaySinh.Value.Date;
        entity.Email = txtEmail.Text.Trim();
        entity.SoDienThoai = txtSoDienThoai.Text.Trim();
        entity.QueQuan = BuildQueQuan();
        entity.DanToc = txtDanToc.Text.Trim();
        entity.TonGiao = txtTonGiao.Text.Trim();
        entity.TrinhDoCMId = GetSelectedId(cboTrinhDoCM);
        entity.TrinhDoLLCTId = GetSelectedId(cboTrinhDoLLCT);
        entity.CapBacId = GetSelectedId(cboCapBac);
        entity.HeSoLuong = decimal.TryParse(txtHeSoLuong.Text, out var heSo) ? heSo : null;
        entity.ChucDanhId = GetSelectedId(cboChucDanh);
        entity.HocHamId = GetSelectedId(cboHocHam);
        entity.HocViId = GetSelectedId(cboHocVi);
        entity.DonViId = GetSelectedId(cboDonVi);
        entity.ChucVu = txtChucVu.Text.Trim();
        entity.LinhVucChuyenMon = txtLinhVuc.Text.Trim();
        entity.NamGanNhatDayGioi = int.TryParse(txtNamDayGioi.Text, out var nam) ? nam : null;

        try
        {
            AppServices.GiangVien.Save(entity);
            LoadData();
        }
        catch (Exception ex)
        {
            messageDialog.Text = $"Không thể lưu giảng viên: {ex.Message}";
            messageDialog.Show();
        }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (_current == null)
        {
            messageDialog.Text = "Chọn một giảng viên để xóa.";
            messageDialog.Show();
            return;
        }

        var confirm = new SiticoneMessageDialog
        {
            Caption = "Xác nhận",
            Text = $"Bạn chắc chắn muốn xóa {_current.HoTen}?",
            Buttons = MessageDialogButtons.YesNo,
            Icon = MessageDialogIcon.Warning
        };

        if (confirm.Show() == DialogResult.Yes)
        {
            try
            {
                AppServices.GiangVien.Delete(_current.GiangVienId);
                LoadData();
            }
            catch (Exception ex)
            {
                messageDialog.Text = $"Không thể xóa: {ex.Message}";
                messageDialog.Show();
            }
        }
    }

    private void SetQueQuanFields(string? queQuan)
    {
        txtQueQuanXa.Text = string.Empty;
        txtQueQuanTinh.Text = string.Empty;
        if (string.IsNullOrWhiteSpace(queQuan))
        {
            return;
        }

        var parts = queQuan.Split(QueQuanSeparator);
        if (parts.Length > 0)
        {
            txtQueQuanXa.Text = parts[0].Trim();
        }

        if (parts.Length > 1)
        {
            txtQueQuanTinh.Text = parts[1].Trim();
        }
    }

    private string? BuildQueQuan()
    {
        var xa = txtQueQuanXa.Text.Trim();
        var tinh = txtQueQuanTinh.Text.Trim();
        if (string.IsNullOrWhiteSpace(xa) && string.IsNullOrWhiteSpace(tinh))
        {
            return null;
        }

        return $"{xa}{QueQuanSeparator}{tinh}".Trim(QueQuanSeparator.ToCharArray());
    }

    private void SelectComboValue(SiticoneComboBox combo, int? value)
    {
        if (value.HasValue)
        {
            combo.SelectedValue = value.Value;
        }
        else
        {
            combo.SelectedIndex = combo.Items.Count > 0 ? 0 : -1;
        }
    }

    private int? GetSelectedId(SiticoneComboBox combo)
    {
        if (combo.SelectedValue == null)
        {
            return null;
        }

        if (combo.SelectedValue is int intValue)
        {
            return intValue;
        }

        return int.TryParse(combo.SelectedValue.ToString(), out var parsed) ? parsed : null;
    }
}
