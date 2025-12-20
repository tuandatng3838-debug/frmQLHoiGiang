using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using FrmQLHoiGiang.Models;
using FrmQLHoiGiang.Services;
using Siticone.Desktop.UI.WinForms;

namespace FrmQLHoiGiang.Controls;

public partial class UcHoiGiang : UserControl
{
    private readonly BindingSource _bindingHoiGiang = new();
    private readonly List<GiangVien> _giangVien = new();
    private readonly List<LookupItem> _capBac = new();
    private readonly List<LookupItem> _chucDanh = new();
    private readonly List<DonVi> _donVi = new();
    private readonly SiticoneTextBox[] _practiceBoxes;
    private List<BaiHoiGiang> _hoiGiang = new();
    private BaiHoiGiang? _selected;

    private SiticoneTextBox[] PracticeScoreBoxes => _practiceBoxes;

    public UcHoiGiang()
    {
        InitializeComponent();
        txtDiemThucHanh.ReadOnly = true;
        _practiceBoxes = CreatePracticeInputs();
        gridHoiGiang.AutoGenerateColumns = false;
        gridHoiGiang.DataSource = _bindingHoiGiang;
        LoadLookups();
        cboGiangVien.SelectedIndexChanged += (_, _) => UpdateGiangVienInfo();
        LoadHoiGiang();
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

        cboHocPhan.DataSource = AppServices.Lookup.GetHocPhan();
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
        if (_hoiGiang.Count > 0)
        {
            gridHoiGiang.Rows[0].Selected = true;
            FillHoiGiangForm(_hoiGiang[0]);
        }
        else
        {
            ClearHoiGiangForm();
        }
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
        btnLuuHoiGiang.Text = "Them moi";
        btnLuuHoiGiang.FillColor = Color.FromArgb(31, 122, 224);
        txtGiangVienDonVi.Text = string.Empty;
        txtGiangVienCapBac.Text = string.Empty;
        txtGiangVienChucDanh.Text = string.Empty;
    }

    private void UpdateGiangVienInfo()
    {
        if (cboGiangVien.SelectedValue is not int id)
        {
            txtGiangVienDonVi.Text = "";
            txtGiangVienCapBac.Text = "";
            txtGiangVienChucDanh.Text = "";
            return;
        }

        var gv = _giangVien.FirstOrDefault(g => g.GiangVienId == id);
        if (gv == null)
        {
            txtGiangVienDonVi.Text = "";
            txtGiangVienCapBac.Text = "";
            txtGiangVienChucDanh.Text = "";
            return;
        }

        txtGiangVienDonVi.Text = _donVi.FirstOrDefault(d => d.Id == gv.DonViId)?.Name ?? string.Empty;
        txtGiangVienCapBac.Text = _capBac.FirstOrDefault(c => c.Id == gv.CapBacId)?.Name ?? string.Empty;
        txtGiangVienChucDanh.Text = _chucDanh.FirstOrDefault(c => c.Id == gv.ChucDanhId)?.Name ?? string.Empty;
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
            dialog.Text = "Chon giang vien va nhap ten bai.";
            dialog.Show();
            return;
        }

        var entity = _selected ?? new BaiHoiGiang();
        var selectedGv = _giangVien.First(g => g.GiangVienId == (int)cboGiangVien.SelectedValue);
        entity.GiangVienId = selectedGv.GiangVienId;
        entity.CapBacId = selectedGv.CapBacId;
        entity.DonViId = selectedGv.DonViId;
        entity.ChucDanhId = selectedGv.ChucDanhId;
        entity.TenBai = txtTenBai.Text.Trim();
        entity.HocPhanId = GetSelectedId(cboHocPhan);
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
            dialog.Text = $"Khong the luu bai hoi giang: {ex.Message}";
            dialog.Show();
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
            dialog.Text = "Chon bai hoi giang truoc khi gan hoi dong.";
            dialog.Show();
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
            dialog.Text = "Can du 5 thanh vien theo co cau.";
            dialog.Show();
            return;
        }

        var selectedIds = selections.Select(x => (int)x.Combo.SelectedValue!).ToList();
        if (selectedIds.Distinct().Count() != selectedIds.Count)
        {
            dialog.Text = "Moi thanh vien chi duoc chon mot lan.";
            dialog.Show();
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
            dialog.Icon = MessageDialogIcon.Information;
            dialog.Text = "Da luu hoi dong.";
            dialog.Show();
        }
        catch (Exception ex)
        {
            dialog.Icon = MessageDialogIcon.Error;
            dialog.Text = $"Khong the luu hoi dong: {ex.Message}";
            dialog.Show();
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
            dialog.Text = "Diem hien biet va ho so khong hop le.";
            dialog.Show();
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
                dialog.Text = "Nhap diem cho moi thanh vien hoi dong.";
                dialog.Show();
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
            dialog.Text = "Chon bai hoi giang.";
            dialog.Show();
            return;
        }

        if (!decimal.TryParse(txtDiemHieuBiet.Text, out var hieuBiet) ||
            !decimal.TryParse(txtDiemHoSo.Text, out var hoSo) ||
            !decimal.TryParse(txtDiemThucHanh.Text, out var thucHanh) ||
            !decimal.TryParse(txtTongDiem.Text, out var tong))
        {
            dialog.Text = "Vui long tinh diem truoc khi luu.";
            dialog.Show();
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
            dialog.Icon = MessageDialogIcon.Information;
            dialog.Text = "Da luu ket qua.";
            dialog.Show();
            LoadHoiGiang();
        }
        catch (Exception ex)
        {
            dialog.Icon = MessageDialogIcon.Error;
            dialog.Text = $"Khong the luu ket qua: {ex.Message}";
            dialog.Show();
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

    private SiticoneTextBox[] CreatePracticeInputs()
    {
        var boxes = new SiticoneTextBox[5];
        for (var i = 0; i < boxes.Length; i++)
        {
            var box = new SiticoneTextBox
            {
                Name = $"txtDiemThanhVien{i + 1}",
                BorderRadius = 8,
                PlaceholderText = $"Diem TV {i + 1}",
                Size = new Size(232, 45),
                Location = new Point(270, 95 + (53 * i))
            };
            tabKetQua.Controls.Add(box);
            boxes[i] = box; 
        }

        return boxes;
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
}
