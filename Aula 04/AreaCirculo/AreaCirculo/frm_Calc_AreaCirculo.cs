using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AreaCirculo
{
    public partial class frm_Calc_AreaCirculo : Form
    {
        public frm_Calc_AreaCirculo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ValRaio = Convert.ToDouble(txt_Raio.Text);
            double ValArea = Math.PI * (ValRaio * ValRaio);
            lbl_Resultado.Text = "A Área do Círculo de Raio " + ValRaio.ToString () + " é " + ValArea.ToString();
            Console.WriteLine(lbl_Resultado.Text);
        }

        private void txt_Raio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
