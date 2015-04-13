using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Execicios_aula04
{
    public partial class form_1 : Form
    {
        public form_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_funcionario Janela = new frm_funcionario();
            Janela.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exercicio_CalculoAreas.form_2 Janela = new Exercicio_CalculoAreas.form_2();
            Janela.Visible = true;
        }

        private void btn_Encerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
