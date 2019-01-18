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
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval;port=5432";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                    

                // Retrieve all rows
                using (var cmd = new NpgsqlCommand("SELECT nomPrenom_RH FROM evaluation", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        Console.WriteLine(reader.GetString(0));
            }

        }
        public static void insertCritere(string lib)
        {
            // Insert some data
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval;port=5432";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO Critere(libellecritere) VALUES ('" + lib + "')";
                    cmd.ExecuteNonQuery();
                }
            }
            
        }

       
    }
}

