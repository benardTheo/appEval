﻿using System;
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
    public partial class coeff_des_criteres : Form
    {
        public coeff_des_criteres(int id)
        {
            InitializeComponent();
            textBox3.Text = id.ToString();
            textBox2.Text = connexion.selectLibC();     
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int id = connexion.selectIdC(textBox2.Text);
            int code = int.Parse(textBox3.Text);
            connexion.insertAssocier(id, code, textBox1.Text);

            MessageBox.Show("Vous avez bien ajouter un nouveau critère", "Vous avez bien ajouter un nouveau critère", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void coeff_des_criteres_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
