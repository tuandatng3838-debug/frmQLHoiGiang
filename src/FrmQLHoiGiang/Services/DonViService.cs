using FrmQLHoiGiang.Models;
using FrmQLHoiGiang.Repositories;

namespace FrmQLHoiGiang.Services;

public class DonViService
{
    private readonly DonViRepository _repository = new();

    public List<DonVi> GetAll() => _repository.GetAll();

    public void Save(DonVi entity)
    {
        if (entity.Id == 0)
        {
            entity.Id = _repository.Insert(entity);
        }
        else
        {
            _repository.Update(entity);
        }
    }

    public void Delete(int id) => _repository.Delete(id);
}
