using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicio_2
{
    public partial class frm_segundo : Form
    {
        public frm_segundo()
        {
            InitializeComponent();
        }

        private void frm2_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Ocorreu o evento Load do Form");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_segundo_Activated(object sender, EventArgs e)
        {

        Console.WriteLine ("Ocorreu o evento activated form2");

        }

        private void frm_segundo_Deactivate(object sender, EventArgs e)
        {

            Console.WriteLine("Ocorreu o evento deactivate do Form2");

        }

        private void frm_segundo_Enter(object sender, EventArgs e)
        {
          
        Console.WriteLine ("Ocorreu o evento Enter do Form2");

        }

        private void frm_segundo_Leave(object sender, EventArgs e)
        {
          
        Console.WriteLine ("Ocorreu o evento Leave do Form2");

        }

        private void txt_teste_Enter(object sender, EventArgs e)
        {

        Console.WriteLine ("Ocorreu o evento Enter do Form2");
}

        }
    }
}
