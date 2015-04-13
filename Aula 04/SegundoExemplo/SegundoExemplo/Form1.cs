using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CriandoStruct; // Criada em tempo de projeto
using CriandoClass; // Criada em tempo de projeto
using CriandoArray; // Criada em tempo de projeto
using DemonstrandoOperadores; // Criada em tempo de projeto
using DemonstrandoComandos; // Criada em tempo de projeto
using Formatacao; // Criada em tempo de projeto
using SpecifyingCaughtException; // Criada em tempo de projeto
/*
 *
 o que for escrito neste espaço é comentário
 * 
 * */


namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        const int valor = 10;
        public Form1()
        {
            InitializeComponent();
        }

    // retorna um valor do tipo int ao sistema
        enum SomeValues: int 
        {
            Primeiro = 20,
            Segundo,
            Terceiro,
            Quarto
        } // Neste caso vai considerar para Primeiro = 0, Segundo = 1, Terceiro = 20 e Quarto = 21

        private void button1_Click(object sender, EventArgs e)
        {
            char c;
            const int x = 32;
            int i;
            bool varBool = true;
            long L = 100;
            i = Convert.ToInt32(L);
            L = i;

            Form2 Janela = new Form2();
            Janela.textBox1.Text = "teste teste teste ";
            Janela.Visible = true;



            // trecho de programa testanto struct e classe criada em um arquivo de código
            Location loc1 = new Location(200, 300);
            loc1.x = 400;
            Console.WriteLine("Loc1 location: {0} xxxxxxxx {1}", loc1, loc1 );
            Tester t = new Tester();
            MessageBox.Show("teste", "xxxx", MessageBoxButtons.RetryCancel);
            t.myFunc(loc1);
            
            Console.WriteLine("Loc1 location: {0}", loc1);
            // final do teste de structure e classe criada no arquivo de nome CodeFile1.cs

            // testanto enumeração
            i = (int)SomeValues.Primeiro;
            Console.WriteLine("{0}", i);
            i = (int)SomeValues.Segundo ;
            Console.WriteLine("{0}", i);
            i = (int)SomeValues.Terceiro;
            Console.WriteLine("{0}", i);
            i = (int)SomeValues.Quarto;
            Console.WriteLine("{0}", i);
            // final do teste de enumeração

            // Testando métodos da classe Console
            // Métodos Read e ReadLine só funcionam em aplicação do tipo Console
            string str;
            // Escreve no console sem retorno de carro
            Console.Write("Digite seu nome: ");
            // Lê uma string do console. <Enter> para concluir
            str = Console.ReadLine();
            // Escreve no console sem retorno de carro
            Console.Write("Digite uma vogal e tecle <Enter>:");
            // Lê do console um caractere simples.
            c = (char)Console.Read();
            // Escreve uma linha em branco
            Console.WriteLine();
            // Escreve uma string no console
            Console.WriteLine("Seu nome é: {0}", str);
            // Escreve 1 caractere com ToString( ) para converter
            Console.WriteLine("Sua vogal: {0}", c.ToString());
            Console.ReadLine();
            // \t = TAB
            // \n = quebra de linha e retorno de carro (CR LF)
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Object VarNome = "Rubens Barrichello"; // Este objeto recebe o valor de uma string.
            Object VarIdade = 29; // Este objeto recebe o valor de um numero;
            Object VarAtivar = true; // Este objeto recebe um valor lógico.

            int VarInteiro = 32450;
            long VarLong = VarInteiro;
            float VarFloat = VarLong;
            double VarDouble = VarFloat;
            decimal VarDecimal = VarLong;
            byte VarByte = (byte)VarInteiro;
            int VarInteiro2 = (int)31.245F;

            Tester2 teste = new Tester2();
            teste.Teste ();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            TesterArray teste= new TesterArray ();
            teste.Teste();
            teste.ChamaFuncaoComParamSArray();
            teste.ArrayMultidimensional();
            teste.ArrayMultidimensional2();
            teste.MetodoArrayDeArrays();
            teste.TestaPropriedadesArray();

            ArrayDinamico testeArray = new ArrayDinamico();
            testeArray.InicializarVetor(5);
            testeArray.InicializarVetor(4);
            testeArray.InicializarVetor(3);
            testeArray.InicializarVetor(2);
            testeArray.InicializarVetor(1);
            testeArray.InicializarVetor(5);
            testeArray.MostraVetor();
            testeArray.RecursosArray();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Operadores teste = new Operadores ();
            teste.Divisao_Modulo();
            teste.PosPreIncrementos();
            teste.DeslocaEsquerda();
            teste.DeslocaDireita();
            teste.OperadorCondicionalTernario();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.WriteLine ("testando o if");
            int  Numero = 10;
            int idade = 20;

            Numero = 3;
            if ( Numero < 10 ) 
            {
                Console.WriteLine("O Número possui 1 dígito");
            }
            else if ( Numero < 100 ) {
                Console.WriteLine("O Número possui 2 dígitos");
            }
            else {
                Console.WriteLine("O Nº possui mais de 2 dígitos");
            }

            Console.WriteLine ( idade >= 18 ? "Maior idade" : "Menor idade" );
            /*
             * Neste exemplo, a instrução condicional contém um contador que é suposto a 
             * contagem 1-100, no entanto, a instrução break termina o loop depois de 
             * 4 contagens.
             * 
             */
            for (int i = 1; i <= 100; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("Testando o switch");
            string Estado = "PR";
            switch ( Estado )
            {
                case "PR" : 
                    Console.WriteLine("Viagem para Curitiba"); 
                    break;
                case "MG" : 
                    Console.WriteLine("Viagem para Belo Horizonte"); 
                    break;
                case "RJ" : 
                    Console.WriteLine("Viagem para o Rio de Janeiro"); 
                    break;
                default:
                    Console.WriteLine("Viagem para São Paulo"); 
                    break;
            }


            Console.WriteLine("Testando o for");
            int [] VetorInteiro = new int [10];
            for ( int i=0; i < 10; i++ )
            {
                Console.WriteLine("Valor de i: " + i );
                VetorInteiro[i] = i*3;
            }

            Console.WriteLine("Testando o foreach");
            foreach ( int i in VetorInteiro )
            {
                Console.WriteLine("Valor do vetor: {0}", i );
            }

            Numero = 0;
            Console.WriteLine("teste while");
            while (Numero < 10)
            {
                Console.WriteLine(Numero);
                Numero++;
            }

            Numero = 0;
            Console.WriteLine("teste do while");
            do
            {
                Numero++;
                Console.WriteLine(Numero);
            }
            while (Numero < 10);

            Comandos Comands = new Comandos();
            Comands.TestaComandos();
            int xx = Comands.CriandoFuncao();
            Console.WriteLine("Retorno da Funcão: {0}", xx);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            testandoTryCatch t = new testandoTryCatch();
            t.InicializaTeste();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            classFormatacao f = new classFormatacao();
            f.FormatacaoNumeros();
            f.FormatacaoDatas();
            f.FormatacaoDatasMetodos();
            }

        private void button8_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Mensagem de erro.", "Título do Erro", MessageBoxButtons.YesNoCancel ))
            {
                case DialogResult.Cancel:
                    break;
                case DialogResult.No :
                    break;
                case DialogResult.Yes:
                    break;
            }
            
            
            if ( MessageBox.Show ("Sair do Sistema?","Sair",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation )  ==  DialogResult.Yes ) 
            {
                this.Close ();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string aux = "99,99";
            double aux2 = Convert.ToDouble(aux);
            Form2 Janela = new Form2();
            Janela.button2.Text = "B2";
            Janela.Visible = true;

        }
    }
}