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
        public static List<candidature> AfficherCandidature(int idOffre)
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval;";
            List<candidature> lesCandidature = new List<candidature>();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                // Retrieve all rows
                using (var cmd = new NpgsqlCommand("SELECT nom_prenom FROM candidature  WHERE codeEmploi = '" + idOffre + "'", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        candidature uneCandidature = new candidature(reader.GetString(0));
                        lesCandidature.Add(uneCandidature);
                    }
            }
            return lesCandidature;
        }

        public static int selectlibE(string lib)
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval;";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                // Retrieve all rows
                using (var cmd = new NpgsqlCommand("SELECT codeemploi FROM offre_emploi Where libelle = '" + lib + "';", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetInt32(0));
                        return reader.GetInt32(0);
                    }
            }
            return 0;
        }
        public static int idNP(string nom_prenom)
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval;";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                // Retrieve all rows
                using (var cmd = new NpgsqlCommand("SELECT codeCandidat FROM candidature Where nom_prenom = '" + nom_prenom + "';", conn))
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



