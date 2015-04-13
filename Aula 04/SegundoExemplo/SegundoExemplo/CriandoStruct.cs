using System;
namespace CriandoStruct
{
    public struct Location
    {
        public int x;
        public int y;

        public Location(int xCoordinate, int yCoordinate)
        {
            x = xCoordinate;
            y = yCoordinate;
        }
        
        public override string ToString( )
        {
            return (String.Format("{0}, {1}", x,y));
        }
    }

    public class Tester
    {
        public   void myFunc(Location loc)
        {
            loc.x = 50;
            loc.y = 100;
            Console.WriteLine("Loc1 location: {0}", loc);
        }
        static void Teste()
        {
            Location loc1 = new Location(200, 300);
            Console.WriteLine("Loc1 location: {0}", loc1);
            Tester t = new Tester();
            t.myFunc(loc1);
            Console.WriteLine("Loc1 location: {0}", loc1);
        }
    }

}
