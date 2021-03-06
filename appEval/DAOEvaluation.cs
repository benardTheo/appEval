﻿using System;
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

        public static void insertEvaluation(string nom, string bonus, string comm, int idCa)
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
                        "VALUES ('" + nom + "','" + date + "'," + bonus + ", '" + comm + "', " + idCa + ");";
                    cmd.ExecuteNonQuery();
                }
            }

        }
        public static void insertNote(int id, int idC, int note , int bonus)
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval";
            int noteF = note + bonus;
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();



                using (var cmd = new NpgsqlCommand())
                {

                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO Noter(idEvaluation ,idCritere,note) VALUES( " + id + "," + idC + "," + noteF + ")";


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

        public static List<Critere> AfficherCritere(int idOffre)
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval";
            List<Critere> lesCriteres = new List<Critere>();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();



                // Retrieve all rows
                using (var cmd = new NpgsqlCommand("SELECT libellecritere FROM critere C INNER JOIN associer A ON C.idcritere = A.idcritere  WHERE codeEmploi = '" + idOffre + "'", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Critere unCritere = new Critere(reader.GetString(0));
                        lesCriteres.Add(unCritere);


                    }

            }
            return lesCriteres;

        }


        public static int coefEtCrit(int idCritere, int note)
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();



                // Retrieve all rows
                using (var cmd = new NpgsqlCommand("SELECT coeff FROM associer  WHERE idcritere = '" + idCritere + "'", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetInt32(0));
                        return reader.GetInt32(0);
                    }
                return 0;

            }
        }
    }
        
}   


