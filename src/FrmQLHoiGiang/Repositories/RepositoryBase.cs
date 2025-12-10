using Microsoft.Data.SqlClient;

namespace FrmQLHoiGiang.Repositories;

public abstract class RepositoryBase
{
    protected SqlConnection OpenConnection() => Data.SqlConnectionFactory.Create();

    protected async Task<SqlConnection> OpenConnectionAsync() => await Data.SqlConnectionFactory.CreateAsync();

    protected static SqlParameter Parameter(string name, object? value)
        => new SqlParameter(name, value ?? DBNull.Value);
}
