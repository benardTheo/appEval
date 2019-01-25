using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace appEval
{
    class DAOEvaluation
    {
        public void insertNote()
        {

        }

        public static void  insertEvaluation(string nom, string bonus ,string comm)
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval";
            DateTime date = new DateTime();
            date = DateTime.Now;

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();



                using (var cmd = new NpgsqlCommand())
                {

                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO EVALUATION( nomPrenom_RH, dateEval, Bonus_Malus, commentaire, codeCandidat) " +
                        "VALUES ('" + nom + "','" + date + "'," + bonus + ", '" + comm + "', 1);";
                    cmd.ExecuteNonQuery();
                }
            }

        }
        public static void insertNote(int id,string note)
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval";
           

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();



                using (var cmd = new NpgsqlCommand())
                {

                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO Noter(idEvaluation ,idCritere,note) VALUES( "+ id+",1," + note + ")";


                    cmd.ExecuteNonQuery();
                }
            }

        }
        public static int selectIDEval()
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                // Retrieve all rows
                using (var cmd = new NpgsqlCommand("SELECT idEvaluation FROM Evaluation order by idEvaluation DESC limit 1;", conn))
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

