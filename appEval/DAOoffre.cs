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
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval;port=5433";
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
    }
}
