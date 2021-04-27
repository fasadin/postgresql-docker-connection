using Npgsql;
using System;

namespace postgresconnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = "Host=127.0.0.1;Username=testuser@test.com;Password=test123!@#;Database=testdb";

            using var con = new NpgsqlConnection(cs);
            con.Open();

            var sql = "SELECT version()";

            using var cmd = new NpgsqlCommand(sql, con);

            var version = cmd.ExecuteScalar().ToString();
            Console.WriteLine($"PostgreSQL version: {version}");
        }
    }
}
