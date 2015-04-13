using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Exercicio_Calculadora;
using Exercicio_CalculoAreas;
using Operacoes_com_Matrizes;


namespace Exerccios_posDOCAula04
{
    public partial class frm_Inicial : Form
    {
        public frm_Inicial()
        {
            InitializeComponent();
        }

        private void btn_Calculadora_Click(object sender, EventArgs e)
        {
            frm_Calc Janela = new frm_Calc();
            Janela.Visible = true;
        }

        private void btn_Encerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Areas_Click(object sender, EventArgs e)
        {
            frm_Areas Janela = new frm_Areas();
            Janela.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Matriz Janela = new frm_Matriz();
            Janela.Visible = true;

        }
    }
}
