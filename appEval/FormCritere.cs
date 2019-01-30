using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace appEval
{
    public partial class FormCritere : Form
    {
        
        public FormCritere(int idOffre)
        {
            InitializeComponent();
            connexion.Connect();
            textBox1.Text = idOffre.ToString();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e) { 
           string libelle = textBox2.Text;
        }
        
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            connexion.insertCritere(textBox2.Text);
            coeff_des_criteres c = new coeff_des_criteres(id);
            c.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
