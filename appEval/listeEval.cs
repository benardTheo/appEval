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
        public listeEval(int idOffre)
        {
            InitializeComponent();

            label2.Text = connexion.selectLibOffre(idOffre.ToString());

            this.dataGridView1.Rows.Add(4);

            this.dataGridView1[0,0].Value = "1";
            this.dataGridView1[0, 1].Value = "2";
            this.dataGridView1[0, 2].Value = "3";
            this.dataGridView1[0, 3].Value = "4";
            this.dataGridView1[0, 4].Value = "5";
            Dictionary<string, double> moy = new Dictionary<string, double>();
            moy = DAOresultatEval.afficherMoy(idOffre);
            int i = 0;
            foreach(KeyValuePair<string, double> elem in moy)
            {
                dataGridView1.Rows[i].Cells[1].Value = elem.Key.ToString();
                dataGridView1.Rows[i].Cells[2].Value = elem.Value.ToString();
                i++;
            }

            
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
