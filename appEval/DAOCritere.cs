﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace appEval
{
    public class DAOCritere
    {
        public static List<Critere> LibelleCritere()
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval;port=5433";
            List<Critere> lesCritere = new List<Critere>();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();



                // Retrieve all rows
                using (var cmd = new NpgsqlCommand("SELECT libelleCritere FROM critere", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Critere unCritere = new Critere(reader.GetString(0));
                        lesCritere.Add(unCritere);


                    }

            }
            return lesCritere;

        }

    }
}
