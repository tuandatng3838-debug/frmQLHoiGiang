using FrmQLHoiGiang.Models;
using FrmQLHoiGiang.Repositories;

namespace FrmQLHoiGiang.Services;

public class LichGiangService
{
    private readonly LichGiangRepository _repository = new();
    private readonly BaiHoiGiangRepository _baiHoiGiangRepository = new();

    public List<LichGiang> GetAll() => _repository.GetAll();

    public (bool Success, string? Error) Save(LichGiang entity)
    {
        var conflict = _repository.CheckConflict(entity.GiangVienId, entity.NgayHoc, entity.Buoi,
            entity.LichGiangId == 0 ? null : entity.LichGiangId);
        if (conflict)
        {
            return (false, "Giang vien da co lich trong buoi nay.");
        }

        if (_baiHoiGiangRepository.HasHoiGiangTrongNgay(entity.GiangVienId, entity.NgayHoc))
        {
            return (false, "Giang vien dang co bai hoi giang trong ngay da chon.");
        }

        if (entity.LichGiangId == 0)
        {
            _repository.Insert(entity);
        }
        else
        {
            _repository.Update(entity);
        }

        return (true, null);
    }

    public void Delete(int id) => _repository.Delete(id);
}
