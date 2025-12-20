using FrmQLHoiGiang.Models;
using FrmQLHoiGiang.Repositories;

namespace FrmQLHoiGiang.Services;

public class KhoaService
{
    private readonly KhoaRepository _repository = new();

    public List<LookupItem> GetAll() => _repository.GetAll();

    public void Save(LookupItem khoa)
    {
        if (khoa.Id == 0)
        {
            khoa.Id = _repository.Insert(khoa.Name);
        }
        else
        {
            _repository.Update(khoa.Id, khoa.Name);
        }
    }

    public void Delete(int id) => _repository.Delete(id);
}
