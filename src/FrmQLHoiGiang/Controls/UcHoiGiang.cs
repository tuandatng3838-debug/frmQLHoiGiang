using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using FrmQLHoiGiang.Models;
using FrmQLHoiGiang.Services;
using FrmQLHoiGiang.Ui;
using Siticone.Desktop.UI.WinForms;

namespace FrmQLHoiGiang.Controls;

public partial class UcHoiGiang : UserControl
{
    private readonly BindingSource _bindingHoiGiang = new();
    private readonly List<GiangVien> _giangVien = new();
    private readonly List<LookupItem> _hocPhan = new();
    private readonly List<LookupItem> _capBac = new();
    private readonly List<LookupItem> _chucDanh = new();
    private readonly List<DonVi> _donVi = new();
    private List<BaiHoiGiang> _hoiGiang = new();
    private BaiHoiGiang? _selected;
    private bool _suppressHocPhanTextChange;

    private SiticoneTextBox[] PracticeScoreBoxes =>
        new[] { txtDiemThanhVien1, txtDiemThanhVien2, txtDiemThanhVien3, txtDiemThanhVien4, txtDiemThanhVien5 };

    public UcHoiGiang()
    {
        InitializeComponent();
        txtDiemThucHanh.ReadOnly = true;
        gridHoiGiang.AutoGenerateColumns = false;
        gridHoiGiang.DataSource = _bindingHoiGiang;
        cboHocPhan.DropDownStyle = ComboBoxStyle.DropDown;
        LoadLookups();
        cboGiangVien.SelectedIndexChanged += (_, _) => UpdateGiangVienInfo();
        cboHocPhan.TextChanged += cboHocPhan_TextChanged;
        LoadHoiGiang();
        AppServices.GiangVien.Changed += HandleGiangVienChanged;
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        dialog.Parent = FindForm();
    }

    private void btnRefreshHoiGiang_Click(object sender, EventArgs e)
    {
        LoadHoiGiang();
    }

    private void LoadLookups()
    {
        _giangVien.Clear();
        _giangVien.AddRange(AppServices.GiangVien.GetGiangVien());
        cboGiangVien.DataSource = _giangVien.ToList();
        cboGiangVien.DisplayMember = "HoTen";
        cboGiangVien.ValueMember = "GiangVienId";

        _hocPhan.Clear();
        _hocPhan.AddRange(AppServices.Lookup.GetHocPhan());
        cboHocPhan.DataSource = _hocPhan.ToList();
        cboHocPhan.DisplayMember = "Name";
        cboHocPhan.ValueMember = "Id";

        _capBac.Clear();
        _capBac.AddRange(AppServices.Lookup.GetCapBac());
        _chucDanh.Clear();
        _chucDanh.AddRange(AppServices.Lookup.GetChucDanhGiangDay());
        _donVi.Clear();
        _donVi.AddRange(AppServices.Lookup.GetDonVi());

        var gvSource = _giangVien.Select(g => new { g.GiangVienId, g.HoTen }).ToList();
        foreach (var combo in new[] { cboThanhVien1, cboThanhVien2, cboThanhVien3, cboThanhVien4, cboThanhVien5 })
        {
            combo.DataSource = gvSource.ToList();
            combo.DisplayMember = "HoTen";
            combo.ValueMember = "GiangVienId";
            combo.SelectedIndex = -1;
        }

        cboCapThucHien.Items.Clear();
        cboCapThucHien.Items.AddRange(new object[] { "Hoc vien", "Cap Bo" });
        cboCapThucHien.SelectedIndex = 0;
    }

    private void LoadHoiGiang()
    {
        _hoiGiang = AppServices.HoiGiang.GetBaiHoiGiang();
        _bindingHoiGiang.DataSource = _hoiGiang;
        BindHoiGiangCombos();
        ClearHoiGiangForm();
        gridHoiGiang.ClearSelection();
    }

    private void BindHoiGiangCombos()
    {
        cboHoiDongBai.DataSource = _hoiGiang.Select(b => new { b.BaiHoiGiangId, b.TenBai }).ToList();
        cboHoiDongBai.DisplayMember = "TenBai";
        cboHoiDongBai.ValueMember = "BaiHoiGiangId";

        cboKetQuaBai.DataSource = _hoiGiang.Select(b => new { b.BaiHoiGiangId, b.TenBai }).ToList();
        cboKetQuaBai.DisplayMember = "TenBai";
        cboKetQuaBai.ValueMember = "BaiHoiGiangId";
    }

    private void cboHocPhan_TextChanged(object? sender, EventArgs e)
    {
        if (_suppressHocPhanTextChange)
        {
            return;
        }

        var text = cboHocPhan.Text.Trim();
        if (string.IsNullOrWhiteSpace(text))
        {
            return;
        }

        var match = _hocPhan.FirstOrDefault(h =>
            string.Equals(h.Name, text, StringComparison.OrdinalIgnoreCase));
        if (match == null)
        {
            return;
        }

        var currentId = GetSelectedId(cboHocPhan);
        if (currentId == match.Id)
        {
            return;
        }

        _suppressHocPhanTextChange = true;
        cboHocPhan.SelectedValue = match.Id;
        _suppressHocPhanTextChange = false;
    }

    private void FillHoiGiangForm(BaiHoiGiang entity)
    {
        _selected = entity;
        cboGiangVien.SelectedValue = entity.GiangVienId;
        txtTenBai.Text = entity.TenBai;
        if (entity.HocPhanId.HasValue)
        {
            cboHocPhan.SelectedValue = entity.HocPhanId.Value;
        }
        else
        {
            cboHocPhan.SelectedIndex = -1;
        }

        txtLop.Text = entity.LopThucHien ?? string.Empty;
        dtThoiGian.Value = entity.ThoiGian;
        cboCapThucHien.SelectedItem = entity.CapThucHien;
        btnLuuHoiGiang.Text = "Cap nhat";
        btnLuuHoiGiang.FillColor = Color.SeaGreen;
        UpdateGiangVienInfo();
    }

    private void ClearHoiGiangForm()
    {
        _selected = null;
        txtTenBai.Text = string.Empty;
        txtLop.Text = string.Empty;
        dtThoiGian.Value = DateTime.Now;
        cboCapThucHien.SelectedIndex = 0;
        cboHocPhan.SelectedIndex = -1;
        cboHocPhan.Text = string.Empty;
        btnLuuHoiGiang.Text = "Them moi";
        btnLuuHoiGiang.FillColor = Color.FromArgb(31, 122, 224);
        txtGiangVienDonVi.Text = string.Empty;
        txtGiangVienCapBac.Text = string.Empty;
        txtGiangVienChucDanh.Text = string.Empty;
        txtGiangVienEmail.Text = string.Empty;
        txtGiangVienDienThoai.Text = string.Empty;
        txtGiangVienNgaySinh.Text = string.Empty;
    }

    private void UpdateGiangVienInfo()
    {
        if (cboGiangVien.SelectedValue is not int id)
        {
            txtGiangVienDonVi.Text = "";
            txtGiangVienCapBac.Text = "";
            txtGiangVienChucDanh.Text = "";
            txtGiangVienEmail.Text = "";
            txtGiangVienDienThoai.Text = "";
            txtGiangVienNgaySinh.Text = "";
            return;
        }

        var gv = _giangVien.FirstOrDefault(g => g.GiangVienId == id);
        if (gv == null)
        {
            txtGiangVienDonVi.Text = "";
            txtGiangVienCapBac.Text = "";
            txtGiangVienChucDanh.Text = "";
            txtGiangVienEmail.Text = "";
            txtGiangVienDienThoai.Text = "";
            txtGiangVienNgaySinh.Text = "";
            return;
        }

        txtGiangVienDonVi.Text = _donVi.FirstOrDefault(d => d.Id == gv.DonViId)?.Name ?? string.Empty;
        txtGiangVienCapBac.Text = _capBac.FirstOrDefault(c => c.Id == gv.CapBacId)?.Name ?? string.Empty;
        txtGiangVienChucDanh.Text = _chucDanh.FirstOrDefault(c => c.Id == gv.ChucDanhId)?.Name ?? string.Empty;
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
private void gridHoiGiang_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= _hoiGiang.Count)
        {
            return;
        }

        FillHoiGiangForm(_hoiGiang[e.RowIndex]);
    }

    private void btnLuuHoiGiang_Click(object sender, EventArgs e)
    {
        if (cboGiangVien.SelectedValue == null || string.IsNullOrWhiteSpace(txtTenBai.Text))
        {
            ShowMessage("Chon giang vien va nhap ten bai.");
            return;
        }

        var entity = _selected ?? new BaiHoiGiang();
        var selectedGv = _giangVien.First(g => g.GiangVienId == (int)cboGiangVien.SelectedValue);
        entity.GiangVienId = selectedGv.GiangVienId;
        entity.CapBacId = selectedGv.CapBacId;
        entity.DonViId = selectedGv.DonViId;
        entity.ChucDanhId = selectedGv.ChucDanhId;
        entity.TenBai = txtTenBai.Text.Trim();
        entity.HocPhanId = GetHocPhanIdFromInput();
        if (!string.IsNullOrWhiteSpace(cboHocPhan.Text) && !entity.HocPhanId.HasValue)
        {
            ShowMessage("Hoc phan khong ton tai. Vui long chon dung ten hoc phan.");
            return;
        }
        entity.LopThucHien = txtLop.Text.Trim();
        entity.ThoiGian = dtThoiGian.Value;
        entity.CapThucHien = cboCapThucHien.SelectedItem?.ToString() ?? "Hoc vien";
        entity.TrangThai ??= "Chua cham";

        try
        {
            AppServices.HoiGiang.SaveBaiHoiGiang(entity);
            LoadHoiGiang();
            ClearHoiGiangForm();
        }
        catch (Exception ex)
        {
            ShowMessage($"Khong the luu bai hoi giang: {ex.Message}", MessageDialogIcon.Error);
        }
    }

    private void btnHoiDongLoad_Click(object sender, EventArgs e)
    {
        LoadHoiDong();
    }

    private void LoadHoiDong()
    {
        if (cboHoiDongBai.SelectedValue == null)
        {
            return;
        }

        var hoiDong = AppServices.HoiGiang.GetHoiDong(Convert.ToInt32(cboHoiDongBai.SelectedValue));
        ClearHoiDongForm();
        if (hoiDong == null)
        {
            return;
        }

        txtTenHoiDong.Text = hoiDong.TenHoiDong;
        var thanhVien = hoiDong.ThanhVien.ToList();
        var members = thanhVien.Where(m => m.VaiTro == "Thanh vien").Take(3).ToList();
        var chair = thanhVien.FirstOrDefault(m => m.VaiTro == "Chu tich Hoi dong");
        var secretary = thanhVien.FirstOrDefault(m => m.VaiTro == "Thu ky");

        if (chair != null) cboThanhVien1.SelectedValue = chair.GiangVienId;
        for (var i = 0; i < members.Count; i++)
        {
            new[] { cboThanhVien2, cboThanhVien3, cboThanhVien4 }[i].SelectedValue = members[i].GiangVienId;
        }

        if (secretary != null) cboThanhVien5.SelectedValue = secretary.GiangVienId;
    }

    private void ClearHoiDongForm()
    {
        txtTenHoiDong.Text = "Hoi dong khoa";
        foreach (var combo in new[] { cboThanhVien1, cboThanhVien2, cboThanhVien3, cboThanhVien4, cboThanhVien5 })
        {
            combo.SelectedIndex = -1;
        }
    }

    private void btnLuuHoiDong_Click(object sender, EventArgs e)
    {
        if (cboHoiDongBai.SelectedValue == null)
        {
            ShowMessage("Chon bai hoi giang truoc khi gan hoi dong.");
            return;
        }

        var selections = new[]
        {
            (Combo:cboThanhVien1, Role:"Chu tich Hoi dong"),
            (Combo:cboThanhVien2, Role:"Thanh vien"),
            (Combo:cboThanhVien3, Role:"Thanh vien"),
            (Combo:cboThanhVien4, Role:"Thanh vien"),
            (Combo:cboThanhVien5, Role:"Thu ky"),
        };

        if (selections.Any(x => x.Combo.SelectedValue == null))
        {
            ShowMessage("Can du 5 thanh vien theo co cau.");
            return;
        }

        var selectedIds = selections.Select(x => (int)x.Combo.SelectedValue!).ToList();
        if (selectedIds.Distinct().Count() != selectedIds.Count)
        {
            ShowMessage("Moi thanh vien chi duoc chon mot lan.");
            return;
        }

        var hoiDong = new HoiDong
        {
            BaiHoiGiangId = Convert.ToInt32(cboHoiDongBai.SelectedValue),
            TenHoiDong = txtTenHoiDong.Text.Trim(),
            NgayLap = DateTime.Now
        };

        foreach (var item in selections)
        {
            hoiDong.ThanhVien.Add(new ThanhVienHoiDong
            {
                GiangVienId = (int)item.Combo.SelectedValue!,
                VaiTro = item.Role
            });
        }

        try
        {
            AppServices.HoiGiang.SaveHoiDong(hoiDong);
            ShowMessage("Da luu hoi dong.", MessageDialogIcon.Information);
        }
        catch (Exception ex)
        {
            ShowMessage($"Khong the luu hoi dong: {ex.Message}", MessageDialogIcon.Error);
        }
    }

    private void btnLoadKetQua_Click(object sender, EventArgs e)
    {
        if (cboKetQuaBai.SelectedValue == null)
        {
            return;
        }

        var ketQua = AppServices.HoiGiang.GetKetQua((int)cboKetQuaBai.SelectedValue);
        foreach (var box in PracticeScoreBoxes)
        {
            box.Text = string.Empty;
        }

        if (ketQua == null)
        {
            txtDiemHieuBiet.Text = "";
            txtDiemHoSo.Text = "";
            txtDiemThucHanh.Text = "";
            txtTongDiem.Text = "";
            txtXepLoai.Text = "";
            return;
        }

        txtTongDiem.Text = ketQua.TongDiem.ToString("0.##");
        txtXepLoai.Text = ketQua.XepLoai;
        txtDiemHieuBiet.Text = ketQua.ThanhPhan.FirstOrDefault(x => x.TenPhanThi == "Phan thi hieu biet")?.Diem.ToString("0.##") ?? "";
        txtDiemHoSo.Text = ketQua.ThanhPhan.FirstOrDefault(x => x.TenPhanThi == "Phan thi gioi thieu giang vien va ho so bai")?.Diem.ToString("0.##") ?? "";
        txtDiemThucHanh.Text = ketQua.ThanhPhan.FirstOrDefault(x => x.TenPhanThi.StartsWith("Phan thuc hanh"))?.Diem.ToString("0.##") ?? "";
    }

    private void btnTinhKetQua_Click(object sender, EventArgs e)
    {
        if (!decimal.TryParse(txtDiemHieuBiet.Text, out var hieuBiet) ||
            !decimal.TryParse(txtDiemHoSo.Text, out var hoSo))
        {
            ShowMessage("Diem hien biet va ho so khong hop le.");
            return;
        }

        if (!TryGetPracticeAverage(out var thucHanh))
        {
            return;
        }

        txtDiemThucHanh.Text = thucHanh.ToString("0.##");
        var tong = hieuBiet + hoSo + thucHanh;
        txtTongDiem.Text = tong.ToString("0.##");

        if (tong >= 95)
        {
            txtXepLoai.Text = "Nhat";
        }
        else if (tong >= 90)
        {
            txtXepLoai.Text = "Nhi";
        }
        else if (tong >= 80)
        {
            txtXepLoai.Text = "Ba";
        }
        else
        {
            txtXepLoai.Text = "Khuyen khich";
        }
    }

    private bool TryGetPracticeAverage(out decimal average)
    {
        average = 0;
        var scores = new List<decimal>();
        foreach (var box in PracticeScoreBoxes)
        {
            if (!decimal.TryParse(box.Text, out var diem))
            {
                ShowMessage("Nhap diem cho moi thanh vien hoi dong.");
                return false;
            }

            scores.Add(diem);
        }

        average = scores.Average();
        return true;
    }

    private void btnLuuKetQua_Click(object sender, EventArgs e)
    {
        if (cboKetQuaBai.SelectedValue == null)
        {
            ShowMessage("Chon bai hoi giang.");
            return;
        }

        if (!decimal.TryParse(txtDiemHieuBiet.Text, out var hieuBiet) ||
            !decimal.TryParse(txtDiemHoSo.Text, out var hoSo) ||
            !decimal.TryParse(txtDiemThucHanh.Text, out var thucHanh) ||
            !decimal.TryParse(txtTongDiem.Text, out var tong))
        {
            ShowMessage("Vui long tinh diem truoc khi luu.");
            return;
        }

        var ketQua = new KetQuaHoiGiang
        {
            BaiHoiGiangId = (int)cboKetQuaBai.SelectedValue,
            TongDiem = tong,
            XepLoai = txtXepLoai.Text
        };

        ketQua.ThanhPhan.Add(new KetQuaThanhPhan { TenPhanThi = "Phan thi hieu biet", Diem = hieuBiet });
        ketQua.ThanhPhan.Add(new KetQuaThanhPhan { TenPhanThi = "Phan thi gioi thieu giang vien va ho so bai", Diem = hoSo });
        ketQua.ThanhPhan.Add(new KetQuaThanhPhan { TenPhanThi = "Phan thuc hanh giang (TB 5 phieu)", Diem = thucHanh });

        try
        {
            AppServices.HoiGiang.SaveKetQua(ketQua);
            ShowMessage("Da luu ket qua.", MessageDialogIcon.Information);
            LoadHoiGiang();
        }
        catch (Exception ex)
        {
            ShowMessage($"Khong the luu ket qua: {ex.Message}", MessageDialogIcon.Error);
        }
    }

    private static int? GetSelectedId(SiticoneComboBox combo)
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

    private int? GetHocPhanIdFromInput()
    {
        var text = cboHocPhan.Text.Trim();
        if (string.IsNullOrWhiteSpace(text))
        {
            return null;
        }

        var match = _hocPhan.FirstOrDefault(h =>
            string.Equals(h.Name, text, StringComparison.OrdinalIgnoreCase));
        return match?.Id;
    }

    private void gridHoiGiang_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void tabDangKy_Click(object sender, EventArgs e)
    {

    }

    private void panelLeft_Paint(object sender, PaintEventArgs e)
    {

    }

    private void panelRight_Paint(object sender, PaintEventArgs e)
    {

    }

    private void tabKetQua_Click(object sender, EventArgs e)
    {

    }

    private void cboHocPhan_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void txtGiangVienDonVi_TextChanged(object sender, EventArgs e)
    {

    }
    private void HandleGiangVienChanged()
    {
        LoadLookups();
    }
}
