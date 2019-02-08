using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace appEval
{
    class DAOresultatEval
    {        public static Dictionary<int, double> afficherMoy()
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=appEval;";
            Dictionary<int, double> moy = new Dictionary<int, double>();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                // Retrieve all rows
                using (var cmd = new NpgsqlCommand(
                    "SELECT C.codecandidat, AVG(note) as note FROM candidature C INNER JOIN evaluation ON C.codecandidat = evaluation.codecandidat INNER JOIN noter ON evaluation.idevaluation = noter.idevaluation GROUP BY C.codecandidat order by note desc ", conn)) 
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        moy[reader.GetInt32(0)] = reader.GetDouble(1);

                    }
            }
            return moy ;
        }
    }
}
