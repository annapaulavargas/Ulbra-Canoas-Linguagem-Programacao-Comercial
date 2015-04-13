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
    public partial class frm_primeiro : Form
    {
        public frm_primeiro()
        {
            InitializeComponent();
        }

        private void frm_primeiro_Load(object sender, EventArgs e)
        {
            
          Console.WriteLine ("Ocorreu o evento Load do Form1");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_segundo Janela = new frm_segundo();
            Janela.Visible = true;
        }

        private void frm_primeiro_Activated(object sender, EventArgs e)
        {
       
            Console.WriteLine ("Ocorreu o evento activated do form1");

        }

        private void frm_primeiro_Deactivate(object sender, EventArgs e)
        {
           

            Console.WriteLine ("Ocorreu o evento deactivate do form1");

        }

        

    }
}
