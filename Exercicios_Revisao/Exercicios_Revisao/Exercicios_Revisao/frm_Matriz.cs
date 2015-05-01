using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Operacoes_com_Matrizes
{
    public partial class frm_Matriz : Form
    {
        int [,] Matriz = new int[5, 5];
        int contador;

        public frm_Matriz()
        {
            InitializeComponent();
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            string x;
            if (contador < 5)
            {
                Matriz[contador, 0] = Convert.ToInt32(NUD_1.Value);
                Matriz[contador, 1] = Convert.ToInt32(NUD_2.Value);
                Matriz[contador, 2] = Convert.ToInt32(NUD_3.Value);
                Matriz[contador, 3] = Convert.ToInt32(NUD_4.Value);
                Matriz[contador, 4] = Convert.ToInt32(NUD_5.Value);

                x = NUD_1.Value.ToString("00") + " | " + NUD_2.Value.ToString("00") + " | " + NUD_3.Value.ToString("00") + " | " + NUD_4.Value.ToString("00") + " | " + NUD_5.Value.ToString("00");
                Console.WriteLine(x);
                contador++;


                lsb_Matriz.Items.Add(x);

            }
            /*
            if (lsb_Matriz.Items.Count < 5)
            {
                Matriz[lsb_Matriz.Items.Count, 0] = Convert.ToInt32(NUD_1.Value);
                Matriz[lsb_Matriz.Items.Count, 1] = Convert.ToInt32(NUD_2.Value);
                Matriz[lsb_Matriz.Items.Count, 2] = Convert.ToInt32(NUD_3.Value);
                Matriz[lsb_Matriz.Items.Count, 3] = Convert.ToInt32(NUD_4.Value);
                Matriz[lsb_Matriz.Items.Count, 4] = Convert.ToInt32(NUD_5.Value);

                x = NUD_1.Value.ToString("00") + " | " + NUD_2.Value.ToString("00") + " | " + NUD_3.Value.ToString("00") + " | " + NUD_4.Value.ToString("00") + " | " + NUD_5.Value.ToString("00");
                Console.WriteLine(x);
                lsb_Matriz.Items.Add(x);
            }
            */

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;
            int j;
            contador = 0;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Matriz[i, j] = 1;
                }
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int soma = 0;
            int i, j;

            if (opt_1.Checked)
            {
                for (i = 0; i < 5; i++)
                {
                    soma += Matriz[i, Convert.ToInt32 (NUD_Col.Value )];
                }
                lbl_Resultado.Text = "Soma Elementos Coluna "+ NUD_Col.Value.ToString() + " = " + soma.ToString();
            }
            if (opt_2.Checked)
            {
                for (j = 0; j < 5; j++)
                {
                    soma += Matriz[Convert.ToInt32 (NUD_Lin.Value ), j];
                }
                lbl_Resultado.Text = "Soma Elementos Linha " + NUD_Lin.Value.ToString() + " = " + soma.ToString();
            }
            if (opt_3.Checked)
            {
                for (i = 0; i < 5; i++)
                {
                    soma += Matriz[i, i];
                }
                lbl_Resultado.Text = "Diagonal Principal = " + soma.ToString();
            }
            if (opt_4.Checked)
            {
                for (i = 0; i < 5; i++)
                {
                    soma += Matriz[4 - i, i];
                }
                lbl_Resultado.Text = "Diagonal Secundária = " + soma.ToString();
            }
            if (opt_5.Checked)
            {
                for (i = 0; i < 3; i++)
                {
                    for (j = i; j < (5 - i); j++)
                    {
                        soma += Matriz[i, j];
                    }
                }
                lbl_Resultado.Text = "Parte Superior = " + soma.ToString();
            }
            if (opt_6.Checked)
            {
                for (j = 0; j < 3; j++)
                {
                    for (i = j; i < (5 - j); i++)
                    {
                        soma += Matriz[i, j];
                    }
                }
                lbl_Resultado.Text = "Parte Lateral Esquerda = " + soma.ToString();
            }
            if (opt_7.Checked)
            {
                for (i = 2; i < 5; i++)
                {
                    for (j = 4-i; j <= (i); j++)
                    {
                        soma += Matriz[i, j];
                    }
                }
                lbl_Resultado.Text = "Parte Inferior = " + soma.ToString();
            }

        }

        private void btn_MostraResultado_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Resultado_Click(object sender, EventArgs e)
        {

        }

        private void opt_1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}