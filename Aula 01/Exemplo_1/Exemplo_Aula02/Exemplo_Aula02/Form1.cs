using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exemplo_Aula02
{
    public partial class frm_primeiro : Form
    {
        public frm_primeiro()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //  label1.Text = textBox1.Text;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seja bem vindo " + txt_Nome.Text + txt_Idade.Text);
            frm_segundo Janela = new frm_segundo();
            Janela.Visible = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {

        }

               // Variável Booleana utilizada para determinar quando foi digitado um número na caixa de texto tct_Idadade
        private bool NaoFoiNumero = false;

        private void txt_Idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica o valor na variável de controle.
            if (NaoFoiNumero == true)
            {
                // Não aceita inclusão do cracter precionado no controle.
                MessageBox.Show("Caracter Inválido");
                e.Handled = true;
            }
        }

            //Neste evento é onde se determina o que foi digitado
            private void txt_Idade_KeyDown(object sender, KeyEventArgs e)
            {
                // Inicializa variável de controle do que foi digitado.
                NaoFoiNumero = false;
                // Verifica se o que foi digitado é uma das teclas numéricas de cima.
                if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                {
                    // Verifica se o que foi digitado é uma das teclas do teclado numérico.
                    if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    {
                        // Verifica se não foi a tecla "BackSpace".
                        if (e.KeyCode != Keys.Back)
                        {
                            // O que foi precionado é uma tecla não numerica.
                            // Atualiza a valiável de controle.
                            NaoFoiNumero = true;
                        }
                    }
                }
              }

            private void txt_Idade_TextChanged(object sender, EventArgs e)
            {

            }
            }
         }
