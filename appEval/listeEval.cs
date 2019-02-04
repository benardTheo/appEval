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
        }

        private void listeEval_Load(object sender, EventArgs e)
        {

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


        }
    }
}
