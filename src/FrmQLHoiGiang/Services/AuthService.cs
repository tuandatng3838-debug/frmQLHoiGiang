using FrmQLHoiGiang.Helpers;
using FrmQLHoiGiang.Models;
using FrmQLHoiGiang.Repositories;

namespace FrmQLHoiGiang.Services;

public class AuthService
{
    private readonly NguoiDungRepository _repository = new();

    public NguoiDung? CurrentUser { get; private set; }

    public bool Login(string username, string password)
    {
        var nguoiDung = _repository.GetByUsername(username);
        if (nguoiDung == null)
        {
            return false;
        }

        var hash = PasswordHasher.Hash(password);
        var isMatch =
            string.Equals(nguoiDung.PasswordHash, hash, StringComparison.OrdinalIgnoreCase) ||
            string.Equals(nguoiDung.PasswordHash, password, StringComparison.Ordinal);

        if (!isMatch)
        {
            return false;
        }

        CurrentUser = nguoiDung;
        return true;
    }
}
