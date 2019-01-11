using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace appEval
{
    public static class connexion
    {
        public static void Connect()
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                // Insert some data
                
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO Critere VALUES ('" +  + "')";
                        cmd.ExecuteNonQuery();
                    }
                

                // Retrieve all rows
                using (var cmd = new NpgsqlCommand("SELECT nomPrenom_RH FROM evaluation", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        Console.WriteLine(reader.GetString(0));
            }

        }
    }
}

