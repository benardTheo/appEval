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

        public static string insertEvaluation()
        {

            DateTime date = new DateTime();
            string dateS = date.TimeOfDay.ToString();

            return dateS;
        }


        public static int selectCritereC(int IDoffre)
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                // Retrieve all rows
                using (var cmd = new NpgsqlCommand("SELECT idcritere FROM associer WHERE codeemploi = '" + IDoffre + "';", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetInt32(0));
                        return reader.GetInt32(0);
                    }
            }
            return IDoffre;
        }

    }
}

