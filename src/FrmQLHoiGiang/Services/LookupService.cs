using FrmQLHoiGiang.Models;
using FrmQLHoiGiang.Repositories;

namespace FrmQLHoiGiang.Services;

public class LookupService
{
    private readonly LookupRepository _repository = new();

    private List<LookupItem>? _capBac;
    private List<LookupItem>? _hocHam;
    private List<LookupItem>? _hocVi;
    private List<LookupItem>? _khoa;
    private List<LookupItem>? _trinhDoCm;
    private List<LookupItem>? _trinhDoLlct;
    private List<LookupItem>? _chucDanh;
    private List<DonVi>? _donVi;
    private List<HocPhan>? _hocPhan;

    public List<LookupItem> GetCapBac() => _capBac ??= _repository.GetLookup("CapBac", "CapBacId", "TenCapBac");
    public List<LookupItem> GetHocHam() => _hocHam ??= _repository.GetLookup("HocHam", "HocHamId", "TenHocHam");
    public List<LookupItem> GetHocVi() => _hocVi ??= _repository.GetLookup("HocVi", "HocViId", "TenHocVi");
    public List<LookupItem> GetKhoa() => _khoa ??= _repository.GetLookup("Khoa", "KhoaId", "TenKhoa");
    public List<LookupItem> GetTrinhDoChuyenMon() => _trinhDoCm ??= _repository.GetLookup("TrinhDoChuyenMon", "TrinhDoCMId", "TenTrinhDo");
    public List<LookupItem> GetTrinhDoLlct() => _trinhDoLlct ??= _repository.GetLookup("TrinhDoLLCT", "TrinhDoLLCTId", "TenTrinhDo");
    public List<LookupItem> GetChucDanhGiangDay() => _chucDanh ??= _repository.GetLookup("ChucDanhGiangDay", "ChucDanhId", "TenChucDanh");
    public List<DonVi> GetDonVi() => _donVi ??= _repository.GetDonVi();
    public List<HocPhan> GetHocPhan() => _hocPhan ??= _repository.GetHocPhan();

    public void RefreshDonVi() => _donVi = null;
    public void RefreshKhoa() => _khoa = null;
}
