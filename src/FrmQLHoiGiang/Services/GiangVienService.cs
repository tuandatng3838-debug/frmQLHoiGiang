using FrmQLHoiGiang.Models;
using FrmQLHoiGiang.Repositories;

namespace FrmQLHoiGiang.Services;

public class GiangVienService
{
    private readonly GiangVienRepository _repository = new();

    public event Action? Changed;

    public List<GiangVien> GetGiangVien() => _repository.GetAll();

    public void Save(GiangVien entity)
    {
        if (entity.GiangVienId == 0)
        {
            _repository.Insert(entity);
        }
        else
        {
            _repository.Update(entity);
        }

        Changed?.Invoke();
    }

    public void Delete(int giangVienId)
    {
        _repository.Delete(giangVienId);
        Changed?.Invoke();
    }
}
