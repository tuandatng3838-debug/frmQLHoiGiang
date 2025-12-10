namespace FrmQLHoiGiang.Models;

public class BaiHoiGiang
{
    public int BaiHoiGiangId { get; set; }
    public int GiangVienId { get; set; }
    public string GiangVien { get; set; } = string.Empty;
    public int? CapBacId { get; set; }
    public string? CapBac { get; set; }
    public int? DonViId { get; set; }
    public string? DonVi { get; set; }
    public int? ChucDanhId { get; set; }
    public string? ChucDanh { get; set; }
    public string TenBai { get; set; } = string.Empty;
    public int? HocPhanId { get; set; }
    public string? HocPhan { get; set; }
    public string? LopThucHien { get; set; }
    public DateTime ThoiGian { get; set; }
    public string CapThucHien { get; set; } = "Hoc vien";
    public string TrangThai { get; set; } = "Chua cham";
}

public class HoiDong
{
    public int HoiDongId { get; set; }
    public int BaiHoiGiangId { get; set; }
    public string TenHoiDong { get; set; } = string.Empty;
    public DateTime NgayLap { get; set; }
    public List<ThanhVienHoiDong> ThanhVien { get; set; } = new();
}

public class ThanhVienHoiDong
{
    public int ThanhVienHoiDongId { get; set; }
    public int HoiDongId { get; set; }
    public int GiangVienId { get; set; }
    public string HoTen { get; set; } = string.Empty;
    public int? CapBacId { get; set; }
    public string? CapBac { get; set; }
    public int? ChucDanhGiangDayId { get; set; }
    public string? ChucDanhGiangDay { get; set; }
    public string VaiTro { get; set; } = string.Empty;
}

public class KetQuaHoiGiang
{
    public int KetQuaHoiGiangId { get; set; }
    public int BaiHoiGiangId { get; set; }
    public decimal TongDiem { get; set; }
    public string XepLoai { get; set; } = string.Empty;
    public List<KetQuaThanhPhan> ThanhPhan { get; set; } = new();
}

public class KetQuaThanhPhan
{
    public int KetQuaThanhPhanId { get; set; }
    public int KetQuaHoiGiangId { get; set; }
    public string TenPhanThi { get; set; } = string.Empty;
    public decimal Diem { get; set; }
}

public class SangKien
{
    public int SangKienId { get; set; }
    public string TenSangKien { get; set; } = string.Empty;
    public int GiangVienId { get; set; }
    public string GiangVien { get; set; } = string.Empty;
    public string TuCach { get; set; } = string.Empty;
    public string Loai { get; set; } = string.Empty;
    public string? LinhVuc { get; set; }
    public string NamHoc { get; set; } = string.Empty;
    public string? ThoiGianThucHien { get; set; }
    public string? DiaDiemPhamVi { get; set; }
    public string? XepLoai { get; set; }
}

public class LichGiang
{
    public int LichGiangId { get; set; }
    public string NamHoc { get; set; } = string.Empty;
    public string TenLop { get; set; } = string.Empty;
    public string TenMon { get; set; } = string.Empty;
    public int GiangVienId { get; set; }
    public string GiangVien { get; set; } = string.Empty;
    public string Buoi { get; set; } = string.Empty;
    public DateTime NgayHoc { get; set; }
    public string? PhongHoc { get; set; }
    public int SoTiet { get; set; }
    public int? SoSinhVien { get; set; }
}

public class NguoiDung
{
    public int NguoiDungId { get; set; }
    public string Username { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string HoTen { get; set; } = string.Empty;
    public string Role { get; set; } = "Admin";
}
