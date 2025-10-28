using MySqlConnector;

namespace MiniWarehouse.Console.Data
{
/// <summary>Factory for creating MySQL database connections.
/// Keeps secrets out of source control.
/// </summary>

public static class MySQLConnectionFactory
{
    /// <summary>Creates a new MySQL database connection.</summary>
    public static MySqlConnection Create()
    {
        // In a real application, do not hardcode the connection string.
        // Use a secure method to store and retrieve database credentials.
        var connectionString = "Server=localhost;Database=miniwarehouse;User ID=root;Password=your_password;";

        return new MySqlConnection(connectionString);
    }
}
}