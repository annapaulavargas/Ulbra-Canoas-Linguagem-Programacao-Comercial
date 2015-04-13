using System;

namespace SpecifyingCaughtException
{
    public class testandoTryCatch
    {
        public  void InicializaTeste()
        {
            testandoTryCatch t = new testandoTryCatch();
            t.TestFunc();
        }

        // try to divide two numbers
        // handle possible exceptions
        public void TestFunc()
        {
            try
            {
                double a = 5;
                double b = 0;
                string aux = b.ToString();
                Console.WriteLine("{0} / {1} = {2}",
                a, b, DoDivide(a, b));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // most derived exception type first
/*            catch (System.DivideByZeroException)
            {
                Console.WriteLine(
                "DivideByZeroException caught!");
            }
            catch (System.ArithmeticException)
            {
                Console.WriteLine(
                "ArithmeticException caught!");
            }

            // generic exception type last
            catch
            {
                Console.WriteLine(
                "Unknown exception caught");
            }
 * */

        }

        // do the division if legal
        public double DoDivide(double a, double b)
        {
            if (b == 0)
                throw new System.DivideByZeroException();
            if (a == 0)
                throw new System.ArithmeticException();
            return a / b;
        }
    }
}
