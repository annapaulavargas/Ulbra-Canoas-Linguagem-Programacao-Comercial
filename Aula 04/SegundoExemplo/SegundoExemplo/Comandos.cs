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
            Console.WriteLine(" ---------------- Instru��o IF ------------------- ");
            Console.Write("Forne�a um n�mero: ");
            string Leia = Console.ReadLine( );
            Leia = "30";
            VarNumero = int.Parse( Leia );
            if (VarNumero < 10) {
                Console.WriteLine(" O Numero possui 1 digito ");
            } else if (VarNumero < 100) {
                Console.WriteLine(" O Numero possui 2 d�gitos ");
            }
            else { Console.WriteLine(" o Numero possui 3 ou mais n�meros ");
            }
            Console.WriteLine( );
            Console.WriteLine(" ---------------- Instru��o SWITCH ------------------- ");
            Console.Write("forne�a a sigla de um Estado da regi�o Sudeste: ");
            Leia = Console.ReadLine();
            Leia = "SP";
            Leia = Leia.ToUpper(); // Transforma o string com letras mai�sculas.
            switch ( Leia )
            {
                case "MG": Console.WriteLine("A capital se chama: Belo Horizonte"); break;
                case "SP": Console.WriteLine("A capital se chama: S�o Paulo"); break;
                case "RJ": Console.WriteLine("A capital se chama: Rio de Janeiro"); break;
                case "ES": Console.WriteLine("A capital se chama: Vit�ria"); break;
                default: Console.WriteLine("Voc� n�o digitou uma sigla correta"); break;
            }
            Console.WriteLine( );
            Console.WriteLine(" ---------------- Instru��o WHILE ------------------- ");
            int Condicao = 1;
            Console.Write("Forne�a um valor para repeti��o de 3 - 7 :");
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

       