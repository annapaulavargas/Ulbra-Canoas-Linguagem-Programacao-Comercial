using System;
namespace CriandoClass
{
    public class Time
    {
        // public methods
        public void DisplayCurrentTime()
        {
            Console.WriteLine(
            "Mostra hora corrente");
        }
        // private variables
        int Year;
        int Month;
        int Date;
        int Hour;
        int Minute;
        int Second;
    }
    public class Tester2
    {
        public  void Teste()
        {
            Time t = new Time();
            t.DisplayCurrentTime();
        }
    }
}

