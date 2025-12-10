using FrmQLHoiGiang.Models;
using FrmQLHoiGiang.Repositories;

namespace FrmQLHoiGiang.Services;

public class SangKienService
{
    private readonly SangKienRepository _repository = new();

    public List<SangKien> GetAll() => _repository.GetAll();

    public void Save(SangKien entity)
    {
        if (entity.SangKienId == 0)
        {
            _repository.Insert(entity);
        }
        else
        {
            _repository.Update(entity);
        }
    }

    public void Delete(int id) => _repository.Delete(id);
}
