using System;
using System.Collections; //Para Utilizar ArrayList
using System.Collections.Generic; // Para utilizar List
using System.Diagnostics; // Para usar Debug
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ValorReferencia_ClassStruct_ArrayArrayListList
{
    public partial class Array_ArrayList_List : Form
    {
        // Declaração da estrutura de coleções
        private string[] Array_private = { };
        public string[] Array_public = { };
        static string[] Array_static = { };
        private ArrayList ArrayList_private = new ArrayList();
        public ArrayList ArrayList_public = new ArrayList();
        static ArrayList ArrayList_static = new ArrayList();
        private List<string> List_private = new List<string>();
        public List<string> List_public = new List<string>();
        static List<string> List_static = new List<string>();

        private string string_private = "";
        public string string_public = "";
        static string string_static = "";


        public Array_ArrayList_List()
        {
            InitializeComponent();
        }

        private void Array_ArrayList_List_Load(object sender, EventArgs e)
        {
            string aux;
            aux = string.Format("Tamanhos Array private = {0}, public = {1} e static = {2}  ///  /n", Array_private.Length, Array_public.Length, Array_static.Length);
            aux += string.Format("ArrayList private = {0}, public = {1} e static = {2}  ///  /n", ArrayList_private.Count, ArrayList_public.Count, ArrayList_static.Count);
            aux += string.Format("List private = {0}, public = {1} e static = {2}  ///  /n", List_private.Count, List_public.Count, List_static.Count);

            Debug.WriteLine(aux);
            Debug.WriteLine("Este evento ocorre antes de ter valores adicionados as coleções ");

        }

        private void bt_Mostra_Click(object sender, EventArgs e)
        {
            lst_Array_private.Items.Clear();
            lst_Array_public.Items.Clear();
            lst_Array_static.Items.Clear();

            lst_ArrayList_private.Items.Clear();
            lst_ArrayList_public.Items.Clear();
            lst_ArrayList_static.Items.Clear();

            lst_List_private.Items.Clear();
            lst_List_public.Items.Clear();
            lst_List_static.Items.Clear();
            int i;
            //Arrays
            for (i = 0; i < Array_private.Length; i++)
            {
                lst_Array_private.Items.Add(Array_private[i]);
            }
            for (i = 0; i < Array_public.Length; i++)
            {
                lst_Array_public.Items.Add(Array_public[i]);
            }
            for (i = 0; i < Array_static.Length; i++)
            {
                lst_Array_static.Items.Add(Array_static[i]);
            }
            //ArrayList
            for (i = 0; i < ArrayList_private.Count; i++)
            {
                lst_ArrayList_private.Items.Add(ArrayList_private[i].ToString());
            }
            for (i = 0; i < ArrayList_public.Count; i++)
            {
                lst_ArrayList_public.Items.Add(ArrayList_public[i].ToString());
            }
            for (i = 0; i < ArrayList_static.Count; i++)
            {
                lst_ArrayList_static.Items.Add(ArrayList_static[i].ToString());
            }
            //List
            for (i = 0; i < List_private.Count; i++)
            {
                lst_List_private.Items.Add(List_private[i]);
            }
            for (i = 0; i < List_public.Count; i++)
            {
                lst_List_public.Items.Add(List_public[i]);
            }
            for (i = 0; i < List_static.Count; i++)
            {
                lst_List_static.Items.Add(List_static[i]);
            }
        }

        private void bt_Armazena_Click(object sender, EventArgs e)
        {
            int posicao_final = 0;

            posicao_final = Array_private.Length - 1;
            Array.Resize(ref Array_private, (Array_private.Length + 1));
            Array_private[posicao_final + 1] = txt_Valor.Text;

            posicao_final = Array_public.Length - 1;
            Array.Resize(ref Array_public, (Array_public.Length + 1));
            Array_public[posicao_final + 1] = txt_Valor.Text;

            posicao_final = Array_static.Length - 1;
            Array.Resize(ref Array_static, (Array_static.Length + 1));
            Array_static[posicao_final + 1] = txt_Valor.Text;

            ArrayList_private.Add(txt_Valor.Text);
            ArrayList_public.Add(txt_Valor.Text);
            ArrayList_static.Add(txt_Valor.Text);

            List_private.Add(txt_Valor.Text);
            List_public.Add(txt_Valor.Text);
            List_static.Add(txt_Valor.Text);
            string_private += txt_Valor.Text;
            string_public  += txt_Valor.Text;
            string_static = txt_Valor.Text + string_static;
            txt_Valor.Text = "";

        }

        private void bt_Limpa_Click(object sender, EventArgs e)
        {
            lst_Array_private.Items.Clear();
            lst_ArrayList_private.Items.Clear();
            lst_List_private.Items.Clear();
            lst_Array_public.Items.Clear();
            lst_ArrayList_public.Items.Clear();
            lst_List_public.Items.Clear();
            lst_Array_static.Items.Clear();
            lst_ArrayList_static.Items.Clear();
            lst_List_static.Items.Clear();

            Array.Resize(ref Array_private, 0);
            Array.Resize(ref Array_public, 0);
            Array.Resize(ref Array_static, 0);
            ArrayList_private.Clear();
            ArrayList_public.Clear();
            ArrayList_static.Clear();
            List_private.Clear();
            List_public.Clear();
            List_static.Clear();

        }

        
    }
}
