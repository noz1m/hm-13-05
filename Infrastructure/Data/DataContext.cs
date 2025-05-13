using System.Data;
using Npgsql;

namespace Infrastructure.Data;

public class DataContext
{
    private const string connectionString = "Server=localhost;Database=cw-13-05;User Id=postgres;Port=5433;Password=nozimjanov";

    public NpgsqlConnection GetDbConnection()
    {
        return new NpgsqlConnection(connectionString);
    }
}
