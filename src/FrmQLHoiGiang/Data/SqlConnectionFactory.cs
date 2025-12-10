using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace FrmQLHoiGiang.Data;

public static class SqlConnectionFactory
{
    private static readonly string ConnectionString =
        ConfigurationManager.ConnectionStrings["QLHoiGiang"]?.ConnectionString
        ?? throw new InvalidOperationException("Connection string 'QLHoiGiang' not found in App.config.");

    public static SqlConnection Create()
    {
        var connection = new SqlConnection(ConnectionString);
        connection.Open();
        return connection;
    }

    public static async Task<SqlConnection> CreateAsync()
    {
        var connection = new SqlConnection(ConnectionString);
        await connection.OpenAsync();
        return connection;
    }

    public static DataTable ExecuteDataTable(string query, params SqlParameter[] parameters)
    {
        using var conn = Create();
        using var cmd = new SqlCommand(query, conn);
        if (parameters?.Length > 0)
        {
            cmd.Parameters.AddRange(parameters);
        }

        using var adapter = new SqlDataAdapter(cmd);
        var table = new DataTable();
        adapter.Fill(table);
        return table;
    }
}
