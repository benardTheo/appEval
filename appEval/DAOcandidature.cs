using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace appEval
{
    public class DAOcandidature
    {

        public static List<candidature> AfficherCandidature()
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval;port=5433";
            List<candidature> lesCandidature = new List<candidature>();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();



                // Retrieve all rows
                using (var cmd = new NpgsqlCommand("SELECT code FROM offre_emploi", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        candidature uneCandidature = new candidature(reader.GetString(0));
                        lesCandidature.Add(uneCandidature);


                    }

            }
            return lesCandidature;

        }
    }
}
