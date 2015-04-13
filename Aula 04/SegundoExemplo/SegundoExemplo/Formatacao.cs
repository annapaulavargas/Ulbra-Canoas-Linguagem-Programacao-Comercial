using System;
using System.Globalization;
namespace Formatacao
{
    public class classFormatacao
    {
        public void FormatacaoNumeros()
        {
            double VarValor = 15680.1248D;
            string VarMostra;
            CultureInfo us = new CultureInfo("en-US"); //Formatacao USA
            VarMostra = VarValor.ToString("n", us);
            Console.WriteLine("ToString('n',us) = " + VarMostra);
            VarMostra = VarValor.ToString("n6", us);
            Console.WriteLine("ToString('n6',us) = " + VarMostra);
            VarMostra = VarValor.ToString("c", us);
            Console.WriteLine("ToString('c',us) = " + VarMostra);
            Console.WriteLine();
            CultureInfo br = new CultureInfo("pt-BR"); //Formatacao Brasil
            VarMostra = VarValor.ToString("n", br);
            Console.WriteLine("ToString('n',br) = " + VarMostra);
            VarMostra = VarValor.ToString("e", br);
            Console.WriteLine("ToString('e',br) = " + VarMostra);
            VarMostra = VarValor.ToString("c", br);
            Console.WriteLine("ToString('c',br) = " + VarMostra);
            Console.WriteLine();
            CultureInfo fr = new CultureInfo("fr-FR"); //Formatacao França
            VarMostra = VarValor.ToString("n", fr);
            Console.WriteLine("ToString('n',fr) = " + VarMostra);
            VarMostra = VarValor.ToString("f3", fr);
            Console.WriteLine("ToString('f3',fr) = " + VarMostra);
            VarMostra = VarValor.ToString("c4", fr);
            Console.WriteLine("ToString('c4',fr) = " + VarMostra);
            Console.WriteLine();
            CultureInfo es = new CultureInfo("es-ES"); //Formatacao Espanha
            VarMostra = VarValor.ToString("n3", es);
            Console.WriteLine("ToString('n3',es) = " + VarMostra);
            VarMostra = VarValor.ToString("g4", es);
            Console.WriteLine("ToString('g4',es) = " + VarMostra);
            VarMostra = VarValor.ToString("c2", es);
            Console.WriteLine("ToString('c2',es) = " + VarMostra);
        }
        public void FormatacaoDatas()
        {
            string VarMostra;
            CultureInfo us = new CultureInfo("en-US");
            CultureInfo br = new CultureInfo("pt-BR");
            CultureInfo fr = new CultureInfo("fr-FR");
            DateTime VarData = new DateTime(2001, 02, 19, 13, 25, 20);
            Console.WriteLine("---- Formatos de Datas USA ---");
            VarMostra = VarData.ToString("dd", us);
            Console.WriteLine("ToString('dd') = " + VarMostra);
            VarMostra = VarData.ToString("dddd", us);
            Console.WriteLine("ToString('dddd') = " + VarMostra);
            VarMostra = VarData.ToString("MMM", us);
            Console.WriteLine("ToString('MMM') = " + VarMostra);
            VarMostra = VarData.ToString("yyyy", us);
            Console.WriteLine("ToString('yyyy') = " + VarMostra);
            Console.WriteLine();
            Console.WriteLine("---- Formatos de Datas Brasil ----");
            VarMostra = VarData.ToString("M", br);
            Console.WriteLine("ToString('M') = " + VarMostra);
            VarMostra = VarData.ToString("dddd", br);
            Console.WriteLine("ToString('dddd') = " + VarMostra);
            VarMostra = VarData.ToString("MM", br);
            Console.WriteLine("ToString('MM') = " + VarMostra);
            VarMostra = VarData.ToString("yy", br);
            Console.WriteLine("ToString('yy') = " + VarMostra);
            Console.WriteLine();
            Console.WriteLine("---- Formatos de Datas Francês ----");
            VarMostra = VarData.ToString("M", fr);
            Console.WriteLine("ToString('M') = " + VarMostra);
            VarMostra = VarData.ToString("dddd", fr);
            Console.WriteLine("ToString('dddd') = " + VarMostra);
            VarMostra = VarData.ToString("MMMM", fr);
            Console.WriteLine("ToString('MMMM') = " + VarMostra);
            VarMostra = VarData.ToString("y", fr);
            Console.WriteLine("ToString('y') = " + VarMostra);
            Console.WriteLine();
        }

        public void FormatacaoDatasMetodos()
        {
            string VarMostra;
            int VarDia;
            DateTime VarData;
            Console.WriteLine("Método DaysInMonth");
            for (int I = 1; I <= 12; I++)
            {
                VarDia = DateTime.DaysInMonth(2002, I);
                
                Console.WriteLine("Nº dias do mês " + I + " é igual a: " + VarDia);
            }
            Console.WriteLine("");
            Console.WriteLine("Método Parse");
            
            VarMostra = DateTime.Parse(DateTime.Now.ToString()).ToString();
            Console.WriteLine(VarMostra);
            VarData = DateTime.Now;
            VarMostra = VarData.ToLongDateString();
            VarMostra = VarData.ToLongTimeString ();
            VarMostra = VarData.ToShortDateString ();
            VarMostra = VarData.ToShortTimeString ();
            VarMostra = VarData.ToString("dd/MM/yy");
            Console.WriteLine("");
            Console.WriteLine("Método AddDays");
            VarData = DateTime.Today;
            Console.WriteLine(VarData.AddDays(5));
            Console.WriteLine("");
            Console.WriteLine("Método DayOfWeek");
            Console.WriteLine(VarData.DayOfWeek);
            int diaSemana = Convert.ToInt32(VarData.DayOfWeek);
            Console.WriteLine(diaSemana);
            Console.WriteLine("");
            Console.WriteLine("Método DayOfYear");
            Console.WriteLine(VarData.DayOfYear);
        }

    }

}

