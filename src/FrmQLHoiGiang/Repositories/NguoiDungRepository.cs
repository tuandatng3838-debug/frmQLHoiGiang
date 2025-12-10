using FrmQLHoiGiang.Models;
using Microsoft.Data.SqlClient;

namespace FrmQLHoiGiang.Repositories;

public class NguoiDungRepository : RepositoryBase
{
    public NguoiDung? GetByUsername(string username)
    {
        const string sql = "SELECT NguoiDungId, Username, PasswordHash, HoTen, Role FROM NguoiDung WHERE Username=@Username";
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@Username", username);
        using var reader = cmd.ExecuteReader();
        if (!reader.Read())
        {
            return null;
        }

        return new NguoiDung
        {
            NguoiDungId = reader.GetInt32(0),
            Username = reader.GetString(1),
            PasswordHash = reader.GetString(2),
            HoTen = reader.IsDBNull(3) ? reader.GetString(1) : reader.GetString(3),
            Role = reader.GetString(4)
        };
    }
}
