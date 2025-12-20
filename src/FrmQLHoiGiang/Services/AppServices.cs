namespace FrmQLHoiGiang.Services;

public static class AppServices
{
    public static LookupService Lookup { get; } = new();
    public static GiangVienService GiangVien { get; } = new();
    public static KhoaService Khoa { get; } = new();
    public static DonViService DonVi { get; } = new();
    public static HoiGiangService HoiGiang { get; } = new();
    public static SangKienService SangKien { get; } = new();
    public static LichGiangService LichGiang { get; } = new();
    public static ThongKeService ThongKe { get; } = new();
    public static AuthService Auth { get; } = new();
}
