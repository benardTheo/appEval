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
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval";

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
        public static void insertAssocier(int id, int code, string coef)
        {
             
            // Insert some data
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();



                using (var cmd = new NpgsqlCommand())
                {

                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO ASSOCIER(idCritere,codeemploi,coeff) VALUES (" + id + "," + code + "," + coef + ")";
                    cmd.ExecuteNonQuery();
                }
            }

        }
        public static string selectLibC()
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                // Retrieve all rows
                using (var cmd = new NpgsqlCommand("SELECT libelleCritere FROM Critere order by idCritere DESC limit 1;", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0));
                        return reader.GetString(0);
                    }
            }
            return "non";

        }

        public static int selectIdC(string lib)
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                // Retrieve all rows
                using (var cmd = new NpgsqlCommand("SELECT idCritere FROM Critere Where libelleCritere = '" + lib + "';", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetInt32(0));
                        return reader.GetInt32(0);
                    }
            }
            return 0;
        }

        public static int selectCodeOffre(string lib)
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                // Retrieve all rows
                using (var cmd = new NpgsqlCommand("SELECT codeEmploi FROM offre_emploi WHERE libelle = '" + lib + "';", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetInt32(0));
                        return reader.GetInt32(0);
                    }
            }
            return 0;

        }






    }

}


