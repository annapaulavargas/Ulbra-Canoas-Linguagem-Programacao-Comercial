using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int var1, var2, var3;
            var1 = 11;
            var2 = 222;
            var3 = 3333;
            Console.WriteLine("var1: {0} \t var2: {1}\t var3: {2}\n", var1, var2, var3);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form_Load");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Mensagem teste", "Título Form", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation  ))
            {
                case DialogResult.Yes:
                    Console.WriteLine("Botão Yes");
                    break;
                case DialogResult.No :
                    Console.WriteLine("Botão No");
                    break;
                case DialogResult.Cancel:
                    Console.WriteLine("Botão Cancel");
                    break;

            }

        }
    }
}
