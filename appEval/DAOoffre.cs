using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace appEval
{
    public class DAOoffre
    {
        public static List<offre> afficherEmplois()
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval;";
            List<offre> lesOffres = new List<offre>();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                // Retrieve all rows
                using (var cmd = new NpgsqlCommand("SELECT codeemploi, libelle FROM offre_emploi", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        offre uneOffre = new offre(reader.GetString(1), reader.GetInt32(0));
                        lesOffres.Add(uneOffre);
                    }
            }
            return lesOffres;
        }

        public static void definirDateLimit(string dateLimit, string lib)
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval";
           
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE offre_emploi SET date_limite = '" + dateLimit + "' WHERE libelle = '"+lib+"' ";
                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}
