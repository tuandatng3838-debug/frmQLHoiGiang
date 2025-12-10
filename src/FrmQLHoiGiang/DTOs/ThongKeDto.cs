namespace FrmQLHoiGiang.DTOs;

public class TietDayTheoGiangVienDto
{
    public string GiangVien { get; set; } = string.Empty;
    public int TongTiet { get; set; }
}

public class TietDayTheoKhoaDto
{
    public string Khoa { get; set; } = string.Empty;
    public int TongTiet { get; set; }
}

public class SangKienTheoGiangVienDto
{
    public string GiangVien { get; set; } = string.Empty;
    public int SoSangKien { get; set; }
}

public class GiaiThuongTheoKhoaDto
{
    public string Khoa { get; set; } = string.Empty;
    public int Nhat { get; set; }
    public int Nhi { get; set; }
    public int Ba { get; set; }
    public int KhuyenKhich { get; set; }
}

public class ThamGiaHoiDongDto
{
    public string ThanhVien { get; set; } = string.Empty;
    public int SoLan { get; set; }
}

public class TongHopHoiGiangDto
{
    public string CapThucHien { get; set; } = string.Empty;
    public int SoBai { get; set; }
}
