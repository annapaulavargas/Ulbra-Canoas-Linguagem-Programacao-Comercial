using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicio_Calculadora
{
    public partial class frm_Calc : Form
    {
        private int operando1;
        private int operando2;
        private string operador;
        private int resultado;
        private bool qual_operando; // true --> operando1   e   false --> operando2

        public frm_Calc()
        {
            InitializeComponent();
        }

        private void frm_Calc_Load(object sender, EventArgs e)
        {
            qual_operando = true ;
            operador = "";
        }

        private void btn_um_Click(object sender, EventArgs e)
        {
            txt_Valor.Text += btn_um.Text;
        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            txt_Valor.Text += btn_dois.Text;
        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            txt_Valor.Text += btn_tres.Text;
        }

        private void btn_quatro_Click(object sender, EventArgs e)
        {
            txt_Valor.Text += btn_quatro.Text;
        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            txt_Valor.Text += btn_cinco.Text;
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            txt_Valor.Text += btn_seis.Text;
        }

        private void btn_sete_Click(object sender, EventArgs e)
        {
            txt_Valor.Text += btn_sete.Text;
        }

        private void btn_oito_Click(object sender, EventArgs e)
        {
            txt_Valor.Text += btn_oito.Text;
        }

        private void btn_nove_Click(object sender, EventArgs e)
        {
            txt_Valor.Text += btn_nove.Text;
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            txt_Valor.Text += btn_zero.Text;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            operando1 = 0;
            operando2 = 0;
            qual_operando = true;
            txt_Valor.Text = "";
            lbl_Resultado.Text = "";
            operador = "";

        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            if (qual_operando) // operando1
            {
                operando1 = Convert.ToInt32(txt_Valor.Text);
                qual_operando = false;
                operador = btn_soma.Text;
                txt_Valor.Text = "";
            }
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            if (qual_operando) // operando1
            {
                operando1 = Convert.ToInt32(txt_Valor.Text);
                qual_operando = false;
                operador = btn_subtracao.Text;
                txt_Valor.Text = "";
            }

        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            if (qual_operando) // operando1
            {
                operando1 = Convert.ToInt32(txt_Valor.Text);
                qual_operando = false;
                operador = btn_multiplicacao.Text;
                txt_Valor.Text = "";
            }
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            if (qual_operando) // operando1
            {
                operando1 = Convert.ToInt32(txt_Valor.Text);
                qual_operando = false;
                operador = btn_divisao.Text;
                txt_Valor.Text = "";
            }
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            if (qual_operando)
            {
                lbl_Resultado.Text = txt_Valor.Text;
            }
            else
            {
                operando2 = Convert.ToInt32(txt_Valor.Text);
                switch (operador)
                {
                    case "+":
                        resultado = operando1 + operando2;
                        break;
                    case "-":
                        resultado = operando1 - operando2;
                        break;
                    case "*":
                        resultado = operando1 * operando2;
                        break;
                    case "/":
                        resultado = operando1 / operando2;
                        break;
                }
                lbl_Resultado.Text = resultado.ToString();
            }
            txt_Valor.Text = "";
            operador = "";
            operando1 = 0;
            operando2 = 0;
            qual_operando = true;
        }
    }
}
