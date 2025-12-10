using System.Security.Cryptography;
using System.Text;

namespace FrmQLHoiGiang.Helpers;

public static class PasswordHasher
{
    public static string Hash(string input)
    {
        using var sha256 = SHA256.Create();
        var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
        var builder = new StringBuilder(bytes.Length * 2);
        foreach (var b in bytes)
        {
            builder.Append(b.ToString("x2"));
        }

        return builder.ToString();
    }
}
