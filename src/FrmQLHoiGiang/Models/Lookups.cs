namespace FrmQLHoiGiang.Models;

public class LookupItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}

public class DonVi : LookupItem
{
    public int KhoaId { get; set; }
    public string Khoa { get; set; } = string.Empty;
}

public class HocPhan : LookupItem
{
    public int SoTinChi { get; set; }
}
