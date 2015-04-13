using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ValorReferencia_ClassStruct_ArrayArrayListList
{
    public partial class Frm_DataHora : Form
    {
        public Frm_DataHora()
        {
            InitializeComponent();
        }

        private void DT_Long_ValueChanged(object sender, EventArgs e)
        {
            lbl_Data.Text = DT_Long.Value.ToLongDateString();
            lbl_DiaSemana.Text = DT_Long.Value.ToString("dddd");
            lbl_Hora.Text = DT_Long.Value.ToLongTimeString();
            double valor_momento = DT_Long.Value.ToOADate();
            Console.WriteLine("valor_momento = " + valor_momento.ToString());
        }

        private void DT_Short_ValueChanged(object sender, EventArgs e)
        {
            lbl_Data.Text = DT_Short.Value.ToShortDateString ();
            lbl_DiaSemana.Text = DT_Short.Value.ToString("ddd");
            lbl_Hora.Text = DT_Short.Value.ToShortTimeString ();
            double valor_momento = DT_Short.Value.ToOADate();
            Console.WriteLine("valor_momento = " + valor_momento.ToString());

        }

        private void DT_Time_ValueChanged(object sender, EventArgs e)
        {
            lbl_Data.Text = DT_Time.Value.ToShortDateString();
            lbl_DiaSemana.Text = DT_Time.Value.ToString("ddd");
            lbl_Hora.Text = DT_Time.Value.ToString ("hh:mm:ss");
            double valor_momento = DT_Time.Value.ToOADate();
            Console.WriteLine("valor_momento = " + valor_momento.ToString());

        }

        private void DT_Custom_ValueChanged(object sender, EventArgs e)
        {
            lbl_Data.Text = DT_Custom.Value.ToString("dddd, dd De MMMM De yyyy");
            lbl_DiaSemana.Text = DT_Custom.Value.ToString("ddd");
            lbl_Hora.Text = DT_Custom.Value.ToString("hh:mm:ss");
            double valor_momento = DT_Custom.Value.ToOADate();
            Console.WriteLine("valor_momento = " + valor_momento.ToString());

        }
    }
}
