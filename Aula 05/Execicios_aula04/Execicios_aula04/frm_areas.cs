using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicio_CalculoAreas
{
    public struct ValoresCalculados
    {
        public double A;
        public double B;
        public double C;
        public string operacao;
        public double Resultado;
    }

    public partial class form_2 : Form
    {
        private int operacao_selecionada;
        private string operacao_texto;
        private double Valor_A;
        private double Valor_B;
        private double Valor_C;

        public ValoresCalculados[] Memoria;

        public form_2()
        {
            InitializeComponent();
        }

        private void frm_Areas_Load(object sender, EventArgs e)
        {
            operacao_selecionada = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            operacao_selecionada = 1;
            operacao_texto = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            operacao_selecionada = 2;
            operacao_texto = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            operacao_selecionada = 3;
            operacao_texto = radioButton3.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            operacao_selecionada = 4;
            operacao_texto = radioButton4.Text;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            operacao_selecionada = 5;
            operacao_texto = radioButton5.Text;
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double resultado = 0;

            Valor_A = (double)NUD_A.Value;
            Valor_B = (double)NUD_B.Value;
            Valor_C = (double)NUD_C.Value;
            switch (operacao_selecionada)
            {
                case 1: // Área do Triângulo Retângulo
                    resultado = (Valor_A * Valor_B) / 2;
                    break;
                case 2: // Área do Círculo
                    resultado = Math.PI * Math.Pow(Valor_C, 2);
                    break;
                case 3: // Área do Quadrado
                    resultado = Valor_A * Valor_A;
                    break;
                case 4: // Área do Retângulo
                    resultado = Valor_A * Valor_B;
                    break;
                case 5: // Área da Superfície do Cubo
                    resultado = 6 * Math.Pow(Valor_C, 2);
                    break;
                default:
                    MessageBox .Show ("Faltou selecionar a operação a ser realizada");
                    return ;
            }
            lbl_Resultado.Text = "Área " + operacao_texto + " = " + Convert.ToString (resultado);

            int tamanho_Antigo = 0;
            if (Memoria != null ) tamanho_Antigo = Memoria.Length ;

            Array.Resize(ref Memoria, (tamanho_Antigo + 1));
            Memoria[tamanho_Antigo].A = Valor_A;
            Memoria[tamanho_Antigo].B = Valor_B;
            Memoria[tamanho_Antigo].C = Valor_C;
            Memoria[tamanho_Antigo].operacao = operacao_texto;
            Memoria[tamanho_Antigo].Resultado = resultado;

            if (NUD_calculoRealizado.Minimum == 0)
            {
                NUD_calculoRealizado.Minimum = 1;
                NUD_calculoRealizado.Maximum = 1;
            } else {
                NUD_calculoRealizado.Maximum += 1;

            }
        }

        private void btn_MostraResultado_Click(object sender, EventArgs e)
        {
            int indice = ((int)NUD_calculoRealizado.Value)-1;
            if (indice <0) return ;
            lbl_Resultado.Text = "Valor de A = " + Memoria[indice].A + "    , ";
            lbl_Resultado.Text += "Valor de B = " + Memoria[indice].B + "    , ";
            lbl_Resultado.Text += "Valor de C = " + Memoria[indice].C + "    , ";
            lbl_Resultado.Text += "Área = " + Memoria[indice].operacao + " = ";
            lbl_Resultado.Text += Memoria[indice].Resultado ;

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            int indice = ((int)NUD_calculoRealizado.Value) - 1;
            if (indice < 0) return;
            Memoria = Memoria.Take(indice).Concat(Memoria.Skip(indice  + 1)).ToArray();
            NUD_calculoRealizado.Maximum -= 1;
            if (NUD_calculoRealizado.Maximum == 0)
            {
                NUD_calculoRealizado.Minimum = 0;
            }

        }

        private void btn_ListaArray_Click(object sender, EventArgs e)
        {
            int i;
            string aux;
            lst_Resultado.Items.Clear();
            txt_Resultado_Listar.Text ="";
            lbl_Resultado_Listar.Text = "";


            for (i = 0; i < Memoria.Length; i++)
            {
                aux = Memoria[i].A.ToString("00") + " | " + Memoria[i].B.ToString("00") + " | " + Memoria[i].C.ToString("00") + " | " + Memoria[i].operacao.PadRight(40) + " | " + Memoria[i].Resultado.ToString("000.0");
                lst_Resultado.Items.Add(aux);
                txt_Resultado_Listar.Text += aux + "\r\n";
                lbl_Resultado_Listar.Text += aux + "\n";

            }
        }

        private void lbl_Resultado_Click(object sender, EventArgs e)
        {

        }
    }
}
