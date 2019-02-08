using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appEval
{
    public partial class listeEval : Form
    {
        public listeEval()
        {
            InitializeComponent();
            this.dataGridView1.Rows.Add(4);

            this.dataGridView1[0,0].Value = "1";
            this.dataGridView1[0, 1].Value = "2";
            this.dataGridView1[0, 2].Value = "3";
            this.dataGridView1[0, 3].Value = "4";
            this.dataGridView1[0, 4].Value = "5";
            Dictionary<int, double> moy = new Dictionary<int, double>();
            moy = DAOresultatEval.afficherMoy();
            

        }

        /*
        SELECT c.codecandidat , note, nomprenom_rh
        FROM candidature c
        INNER JOIN evaluation e on e.codecandidat = c.codecandidat
        INNER JOIN noter n on n.idevaluation = e.idevaluation
        order by c.codecandidat;

        SELECT C.codecandidat, AVG(note) as "Moyenne"
        FROM candidature C
        INNER JOIN evaluation ON C.codecandidat = evaluation.codecandidat
        INNER JOIN noter ON evaluation.idevaluation = noter.idevaluation
        GROUP BY C.codecandidat;
        */

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
