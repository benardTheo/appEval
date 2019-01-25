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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


            foreach(offre o in DAOoffre.afficherEmplois())
            {
                listBox1.Items.Add(o.GetLibelle());
            }
             
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            listBox2.Items.Clear();
            foreach (candidature c in DAOcandidature.AfficherCandidature(DAOcandidature.selectlibE(listBox1.Text)))
            {
                
                listBox2.Items.Add(c.GetCodeCandidat());
                
            }
            
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ev1 = DAOcandidature.selectlibE(listBox1.Text);
            Evaluation ev = new Evaluation(ev1);
            ev.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
