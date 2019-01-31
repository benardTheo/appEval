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
    public partial class Evaluation : Form
    {
        public Evaluation(int idOffre,string idCandidat)
        {
            int id = idOffre;
            string idCa = idCandidat;
            InitializeComponent();

            foreach (Critere c in DAOEvaluation.AfficherCritere(id) )
            {
                listBox1.Items.Add(c.LibelleCritere);
            }
            textBox1.Text = id.ToString() ;
            textBox3.Text = idCa;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           int id_crit = connexion.selectIdC(listBox1.Text);
           int note1 = int.Parse(note.Text);
           int coeff =  DAOEvaluation.coefEtCrit(id_crit,note1);
           DAOEvaluation.insertEvaluation(textBox1.Text, comboBox2.Text, textBox2.Text, textBox3.Text);
           int noteF = coeff * note1;
           DAOEvaluation.insertNote(DAOEvaluation.selectIDEval(),connexion.selectIdC(listBox1.Text) ,noteF);


            MessageBox.Show("Evaluation", "Evaluation faite", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Evaluation_Load(object sender, EventArgs e)
        {

        }
    }
}
