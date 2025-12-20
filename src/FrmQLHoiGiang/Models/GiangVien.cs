namespace FrmQLHoiGiang.Models;

public class GiangVien
{
    public int GiangVienId { get; set; }
    public string MaSo { get; set; } = string.Empty;
    public string HoTen { get; set; } = string.Empty;
    public bool GioiTinh { get; set; }
    public DateTime NgaySinh { get; set; }
    public string? QueQuan { get; set; }
    public string? DanToc { get; set; }
    public string? TonGiao { get; set; }
    public string? SoDienThoai { get; set; }
    public string? Email { get; set; }
    public int? TrinhDoCMId { get; set; }
    public int? TrinhDoLLCTId { get; set; }
    public int? DonViId { get; set; }
    public int? KhoaId { get; set; }
    public string? ChucVu { get; set; }
    public int? CapBacId { get; set; }
    public decimal? HeSoLuong { get; set; }
    public int? ChucDanhId { get; set; }
    public int? HocHamId { get; set; }
    public int? HocViId { get; set; }
    public string? LinhVucChuyenMon { get; set; }
    public int? NamGanNhatDayGioi { get; set; }
}
