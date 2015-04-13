using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExemploClassStruct;

namespace ValorReferencia_ClassStruct_ArrayArrayListList
{
    public partial class Form1 : Form
    {
        public string[] Array_public = { };
        public ArrayList ArrayList_public = new ArrayList();
        public List<string> List_public = new List<string>();
        public string string_public ="" ;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Array_ArrayList_List Janela = new Array_ArrayList_List();
            Janela.List_public = List_public;
            Janela.ArrayList_public = ArrayList_public;
            Janela.Array_public = Array_public;
            Janela.string_public = string_public;
            Janela.Visible = true;
            
            //Mostra_Listas(Janela.List_public, Janela.ArrayList_public, Janela.Array_public);
            
        }
        private void Mostra_Listas(List<string> List_public, ArrayList ArrayList_public, params string[] Array_public )
        {
            try
            {
                //params tem que ser o último parâmetro
                lst_Array_public.Items.Clear();
                lst_ArrayList_public.Items.Clear();
                lst_List_public.Items.Clear();

                int i;
                //Arrays
                for (i = 0; i < Array_public.Length; i++)
                {
                    lst_Array_public.Items.Add(Array_public[i]);
                }

                //ArrayList
                for (i = 0; i < ArrayList_public.Count; i++)
                {
                    lst_ArrayList_public.Items.Add(ArrayList_public[i].ToString());
                }
                //List
                for (i = 0; i < List_public.Count; i++)
                {
                    lst_List_public.Items.Add(List_public[i]);
                }
                Console.WriteLine("string_public = {0}", string_public);
            }
            catch (System.ArgumentNullException)
            {
                Console.WriteLine("Erro1");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO  Mostra_Listas= " + ex.Message);
            }
           

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            try
            {
                 Console.WriteLine("List_public.Count = {0}", List_public.Count);
                Console.WriteLine("ArrayList_public.Count = {0}", ArrayList_public.Count);
                Console.WriteLine("Array_public.Lenght = {0}", Array_public.Length);
                Console.WriteLine("string_public.Lenght = {0}", string_public.Length );
                Mostra_Listas(List_public, ArrayList_public, Array_public);
                this.Text = "Exemplo Array ArrayList List";
           }
            catch (System.ArgumentNullException)
            {
                Console.WriteLine("Erro1 Activated ArgumentNullException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO Form1_Activated= " + ex.Message);
            }
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExemploClasse ExClass = new ExemploClasse();
            ExemploStruct ExStruct = new ExemploStruct(2, 4, 5);
            //DateTime  aux = dateTimePicker1.Format("d/MM/yyyy");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_DataHora Janela = new Frm_DataHora();
            Janela.Visible = true;
        }

        
    }
}
