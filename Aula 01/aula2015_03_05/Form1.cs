using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aula2015_03_05
{
    public partial class frm_primeiro : Form
    {
        public frm_primeiro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = textBox3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_segundo Janela = new frm_segundo();
            Janela.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
