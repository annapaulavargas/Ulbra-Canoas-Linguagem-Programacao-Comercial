using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploClassStruct
{
    class ExemploClasse
    {
        public int valorPublic;
        private int valorPrivate;
        static int valorStastic;

        public ExemploClasse()
        {
            valorPrivate = 2;
            valorPublic = 3;
            valorStastic = 4;
            int i = retornoExemploClasse(valorPrivate, valorPublic, valorStastic);
            Console.WriteLine("Resultado ExemploClasse = {0}", i);

        }
        private int retornoExemploClasse(int a, int b, int c)
        {
            return( a * b * c);

        }

    }
    struct ExemploStruct
    {
        public int valorPublic;
        private int valorPrivate;
        static int valorStastic;

        public ExemploStruct(int a, int b, int c)
        {
            valorPrivate = a;
            valorPublic = b;
            valorStastic = c;
            int i = retornoExemploStruct(valorPrivate, valorPublic, valorStastic);
            Console.WriteLine("Resultado ExemploStruct = {0}", i);

        }
         int retornoExemploStruct(int a, int b, int c)
        {
            return (a * b * c);

        }

    }
}
