using System;

namespace Vsite.CSharp
{
    public class PreopterećenjePorazumijevaniArg
    {
        //  Pokrenuti program i provjeriti ispise.
        public static int Zbroji(int x = 1, int y = 2, int z = 3) 
        {
            return x + y + z;
        }

        //  Preopteretiti funkciju Zbroji novom funkcijom public static int Zbroji(int x, int y) koja će vratiti zbroj argumenata. Ponovno pokrenuti programa te usporediti ispise.
        public static int Zbroji(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Zbroji(5, 6, 7));
            Console.WriteLine(Zbroji(5, 5));
            Console.WriteLine(Zbroji(3));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
