using System;
namespace DemonstrandoComandos
{
    class Comandos
    {
        public void TestaComandos()
        {
            int VarNumero = 0;
            int x = 0;
            while (true)
            {
                x++;
                if (x == 7) break;
            }
            Console.WriteLine(" ---------------- Instrução IF ------------------- ");
            Console.Write("Forneça um número: ");
            string Leia = Console.ReadLine( );
            Leia = "30";
            VarNumero = int.Parse( Leia );
            if (VarNumero < 10) {
                Console.WriteLine(" O Numero possui 1 digito ");
            } else if (VarNumero < 100) {
                Console.WriteLine(" O Numero possui 2 dígitos ");
            }
            else { Console.WriteLine(" o Numero possui 3 ou mais números ");
            }
            Console.WriteLine( );
            Console.WriteLine(" ---------------- Instrução SWITCH ------------------- ");
            Console.Write("forneça a sigla de um Estado da região Sudeste: ");
            Leia = Console.ReadLine();
            Leia = "SP";
            Leia = Leia.ToUpper(); // Transforma o string com letras maiúsculas.
            switch ( Leia )
            {
                case "MG": Console.WriteLine("A capital se chama: Belo Horizonte"); break;
                case "SP": Console.WriteLine("A capital se chama: São Paulo"); break;
                case "RJ": Console.WriteLine("A capital se chama: Rio de Janeiro"); break;
                case "ES": Console.WriteLine("A capital se chama: Vitória"); break;
                default: Console.WriteLine("Você não digitou uma sigla correta"); break;
            }
            Console.WriteLine( );
            Console.WriteLine(" ---------------- Instrução WHILE ------------------- ");
            int Condicao = 1;
            Console.Write("Forneça um valor para repetição de 3 - 7 :");
            Leia = Console.ReadLine( );
            Leia = "5";
            VarNumero = int.Parse( Leia );
            int Final =1;
            if (VarNumero > 2) {
                if (VarNumero < 8) {
                    Final = VarNumero;
                }
                else { 
                    Final = 2;
                }
            }
            Console.WriteLine( Final==2 ? "Valor Incorreto" : "Valor Correto" );
            while ( Condicao <= Final )
            {
            Console.WriteLine("Valor da variavel Condicao: {0}", Condicao);
            Condicao++;
            }
        }
        public int CriandoFuncao()
        {
            int VarNumero = 0;
            return VarNumero; 
        }

    }
    class segundaClasse
    {
 
    }
}

       