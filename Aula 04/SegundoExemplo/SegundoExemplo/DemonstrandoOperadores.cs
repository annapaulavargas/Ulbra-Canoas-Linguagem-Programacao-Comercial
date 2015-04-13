using System;
namespace DemonstrandoOperadores
{
    class Operadores
    {
        public int xxxx;

        public void Divisao_Modulo()
        {
            int i1, i2;
            float f1, f2;
            double d1, d2;
            decimal dec1, dec2;
            i1 = 17;
            i2 = 4;
            f1 = 17f;
            f2 = 4f;
            d1 = 17;
            d2 = 4;
            dec1 = 17;
            dec2 = 4;
            Console.WriteLine("Integer:\t{0}\nfloat:\t\t{1}",
            i1 / i2, f1 / f2);
            Console.WriteLine("double:\t\t{0}\ndecimal:\t{1}",
            d1 / d2, dec1 / dec2);
            Console.WriteLine("\nModulus:\t{0}", i1 % i2);
        }
        
        public void PosPreIncrementos()
        {
            int valueOne = 10;
            int valueTwo;
            valueTwo = valueOne++;
            Console.WriteLine("Pós-fixado: {0}, {1}", valueOne, valueTwo);
            valueOne = 20;
            valueTwo = ++valueOne;
            Console.WriteLine("Pré-fixado: {0}, {1}", valueOne, valueTwo);
        }

        public void DeslocaDireita()
        {
            int i = -1000;
            Console.WriteLine(i >> 3);
        }

        public void DeslocaEsquerda()
        {
            int i = 1; // 4 bytes com sinal
            long lg = 1; // 8 bytes com sinal

            Console.WriteLine("(int)0x{0:x}", i);

            Console.WriteLine("(int)1<<1 0x{0:x}", i << 1);
            Console.WriteLine("(int)1<<8 0x{0:x}", i << 8);
            Console.WriteLine("(int)1<33 0x{0:x}", i << 33);
            Console.WriteLine("(int)1<<32 0x{0:x}", i << 32);
            Console.WriteLine("(long)1<<33 0x{0:x}", lg << 33);
        }
        public void OperadorCondicionalTernario()
        {
            int valueOne = 10;
            int valueTwo = 20;
            int maxValue = valueOne > valueTwo ? valueOne : valueTwo;
            Console.WriteLine("ValueOne: {0}, valueTwo: {1}, maxValue: {2}",
            valueOne, valueTwo, maxValue);
        }


    }


}

