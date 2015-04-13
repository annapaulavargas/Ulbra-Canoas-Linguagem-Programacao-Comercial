using System;
using System.Collections;


namespace CriandoArray
{
// a simple class to store in the array
    public class Empregado
    {
    // a simple class to store in the array
        public Empregado(int empID)
        {
            this.empID = empID;
        }

        public override string ToString( )
        {
            return empID.ToString( );
        }

        private int empID;
    }

    public class TesterArray
    {
        public  void Teste( )
        {
            int[] intArray;
            Empregado[] empArray;
            intArray = new int[5];
            empArray = new Empregado[3];
            // populate the array
            for (int i = 0;i<empArray.Length;i++)
            {
                empArray[i] = new Empregado(i + 5);
            }
            for (int i = 0;i<intArray.Length;i++)
            {
                Console.WriteLine(intArray[i].ToString( ));
            }
            for (int i = 0;i<empArray.Length;i++)
            {
                Console.WriteLine(empArray[i].ToString( ));
            }

            int[] myIntArray = new int[5] { 2, 4, 6, 8, 10 };
            // ou 
            // int[] myIntArray = { 2, 4, 6, 8, 10 };
            for (int i = 0; i < myIntArray.Length; i++)
            {
                Console.WriteLine(myIntArray[i].ToString());
            }

        }
        
        public void TestaPropriedadesArray()
        {
            int[] myIntArray = new int[15] { 2, 4, 6, 8, 10, 2, 4, 6, 8, 10, 2, 4, 6, 8, 10 };
            int i;

            i = myIntArray.Length; // Tamanho do vetor;
            Console.WriteLine("Length = {0}", i );
            i = Array.IndexOf(myIntArray, 6); // Procura a primeira ocorrência de valor em vetor;
            Console.WriteLine("IndexOf = {0}", i );
            i = Array.LastIndexOf(myIntArray, 6); // Procura a última ocorrência de valor em vetor;
            Console.WriteLine("LastIndexOf = {0}", i );
            Array.Sort(myIntArray); // Ordena um vetor crescentemente;
            for (i = 0; i < myIntArray.Length; i++)
            {
                Console.Write(myIntArray[i].ToString() + ", ");
            }
            Array.Reverse(myIntArray); // Ordena um vetor decrescentemente.
            for (i = 0; i < myIntArray.Length; i++)
            {
                Console.Write(myIntArray[i].ToString() + ", ");
            }

        }

        public void ChamaFuncaoComParamSArray( )
        {
            TesterArray t = new TesterArray();
            t.MostraValores (5,6,7,8);
            int [] explicitArray = new int[5] {1,2,3,4,5};
            t.MostraValores(explicitArray);
        }

        public void MostraValores(params int[] intVals)
        {
            foreach (int i in intVals)
            {
                Console.WriteLine("Mostra Valor {0}",i);
            }

            int x = intVals.Length;
        }
       

        public void ArrayMultidimensional( )
        {
            const int rows = 4;
            const int columns = 3;
            // declare a 4x3 integer array
            int[,] ArrayRetangular = new int[rows, columns];
            // populate the array

            for (int i = 0;i < rows;i++)
            {
                for (int j = 0;j<columns;j++)
                {
                    ArrayRetangular[i, j] = i + j;
                }
            }
            // report the contents of the array
            Console.WriteLine("Resultados da ArrayMultidimensional");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0;j<columns;j++)
                {
                    Console.WriteLine("ArrayRetangular[{0},{1}] = {2}",
                    i, j, ArrayRetangular[i, j]);
                }
            }
        }

        public void ArrayMultidimensional2()
        {
            const int rows = 4;
            const int columns = 3;
            // imply a 4x3 array
            int[,] rectangularArray =
            { {0,1,2}, {3,4,5}, {6,7,8}, {9,10,11} };
            Console.WriteLine("Resultados da ArrayMultidimensional2");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("rectangularArray[{0},{1}] = {2}",
                    i, j, rectangularArray[i, j]);
                }
            }
        }

        public void MetodoArrayDeArrays()
        {
            const int rows = 4;
            // declare the jagged array as 4 rows high
            int[][] ArrayDeArrays = new int[rows][];
            // the first row has 5 elements
            ArrayDeArrays[0] = new int[5];
            // a row with 2 elements
            ArrayDeArrays[1] = new int[2];
            // a row with 3 elements
            ArrayDeArrays[2] = new int[3];
            // the last row has 5 elements
            ArrayDeArrays[3] = new int[5];
            // Fill some (but not all) elements of the rows
            ArrayDeArrays[0][3] = 15;
            ArrayDeArrays[1][1] = 12;
            ArrayDeArrays[2][1] = 9;
            ArrayDeArrays[2][2] = 99;
            ArrayDeArrays[3][0] = 10;
            ArrayDeArrays[3][1] = 11;
            ArrayDeArrays[3][2] = 12;
            ArrayDeArrays[3][3] = 13;
            ArrayDeArrays[3][4] = 14;
            Console.WriteLine("Resultados da MetodoArrayDeArrays");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ArrayDeArrays[0][{0}] = {1}",
                i,ArrayDeArrays[0][i]);
            }
            for (int i = 0;i < 2; i++)
            {
                Console.WriteLine("ArrayDeArrays[1][{0}] = {1}",
                i,ArrayDeArrays[1][i]);
            }
            for (int i = 0;i < 3; i++)
            {
                Console.WriteLine("ArrayDeArrays[2][{0}] = {1}",
                i,ArrayDeArrays[2][i]);
            }
            for (int i = 0;i < 5; i++)
            {
                Console.WriteLine("ArrayDeArrays[3][{0}] = {1}",
                i, ArrayDeArrays[3][i]);
            }
        }
    }
    public class ArrayDinamico
    {

        public int[] Vetor = { };
        public int[] Vetor2 = { };
        public int[] Vetor3 = { };

        public void InicializarVetor(int numID)
        {
            int i;
            int posicao_inicial = Vetor.Length;

            Array.Resize(ref Vetor, (Vetor.Length + numID));
            for (i = 0; i < numID ; i++)
            {
                Vetor[i + posicao_inicial] = Vetor.Length+i ;
            }
        }
        public void RecursosArray()
        {
            int i;

            int tamanho = Vetor.Length; 
            int dimensoes = Vetor.Rank; 
            int dim1 = Vetor.GetLength(0); 
            int inferior = Vetor.GetLowerBound(0); 
            int superior = Vetor.GetUpperBound(0); 
            Vetor.SetValue(3333, 5);
            int Valor = (int) Vetor.GetValue(6);
            Array.IndexOf(Vetor, 2); 
            Array.LastIndexOf(Vetor, 12);

            Console.WriteLine();
            Console.Write("Vetor = ");

            for (i = 0; i < Vetor.Length; i++)
            {
                Console.Write("   {0}", Vetor[i]);
            }
            Console.WriteLine();
            Array.Resize(ref Vetor2, Vetor.Length);
            Array.Resize (ref Vetor3 , Vetor.Length );
            Vetor.CopyTo(Vetor2, 0);
            Array.Copy(Vetor, Vetor3, Vetor.Length);
            Array.Sort(Vetor2);
            Console.WriteLine();
            Console.Write("Vetor2 = ");

            for (i = 0; i < Vetor2.Length; i++)
            {
                Console.Write("   {0}", Vetor2[i]);
            }
            Console.WriteLine();

            Array.Reverse(Vetor3);
            Console.WriteLine();
            Console.Write("Vetor3 = ");

            for (i = 0; i < Vetor3.Length; i++)
            {
                Console.Write("   {0}", Vetor3[i]);
            }
            Console.WriteLine();

            Array.Clear(Vetor2, 0, Vetor2.Length); //Todos elementos
            Console.Write("Vetor2 = ");

            for (i = 0; i < Vetor2.Length; i++)
            {
                Console.Write("   {0}", Vetor2[i]);
            }
            Console.WriteLine();


            Array.Clear(Vetor3, 1, 2); //2 elementos a partir da 2ª posição
            Console.Write("Vetor3 = ");

            for (i = 0; i < Vetor3.Length; i++)
            {
                Console.Write("   {0}", Vetor3[i]);
            }
            Console.WriteLine();

        }

        public void MostraVetor()
        {
            int i;
            Console.WriteLine();
            Console.Write("Vetor = ");

            for (i = 0; i < Vetor.Length; i++)
            {
                Console.Write ("   {0}",Vetor[i]);
            }
            Console.WriteLine();
        }
        
    }

}