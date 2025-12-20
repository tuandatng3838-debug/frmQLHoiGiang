using FrmQLHoiGiang.Models;
using FrmQLHoiGiang.Repositories;

namespace FrmQLHoiGiang.Services;

public class HoiGiangService
{
    private readonly BaiHoiGiangRepository _baiHoiGiangRepository = new();
    private readonly HoiDongRepository _hoiDongRepository = new();
    private readonly KetQuaRepository _ketQuaRepository = new();

    public List<BaiHoiGiang> GetBaiHoiGiang() => _baiHoiGiangRepository.GetAll();

    public void SaveBaiHoiGiang(BaiHoiGiang entity)
    {
        if (entity.BaiHoiGiangId == 0)
        {
            _baiHoiGiangRepository.Insert(entity);
        }
        else
        {
            _baiHoiGiangRepository.Update(entity);
        }
    }

    public HoiDong? GetHoiDong(int baiHoiGiangId) => _hoiDongRepository.GetByBaiHoiGiangId(baiHoiGiangId);

    public void SaveHoiDong(HoiDong hoiDong)
    {
        var existing = _hoiDongRepository.GetByBaiHoiGiangId(hoiDong.BaiHoiGiangId);
        var hoiDongId = existing?.HoiDongId ?? _hoiDongRepository.InsertHoiDong(hoiDong);
        _hoiDongRepository.ReplaceThanhVien(hoiDongId, hoiDong.ThanhVien);
        _baiHoiGiangRepository.UpdateTrangThai(hoiDong.BaiHoiGiangId, "Dang cham");
    }

    public KetQuaHoiGiang? GetKetQua(int baiHoiGiangId) => _ketQuaRepository.GetByBaiHoiGiang(baiHoiGiangId);

    public void SaveKetQua(KetQuaHoiGiang ketQua)
    {
        _ketQuaRepository.Upsert(ketQua);
        _baiHoiGiangRepository.UpdateTrangThai(ketQua.BaiHoiGiangId, "Da cham");
    }

    public void DeleteBaiHoiGiang(int baiHoiGiangId)
    {
        _baiHoiGiangRepository.DeleteCascade(baiHoiGiangId);
    }
}
