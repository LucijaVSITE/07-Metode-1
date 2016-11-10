using System;

namespace Vsite.CSharp
{
    public class Preopterećenje
    {
        // Pokrenuti program i provjeriti ispis.
        public static void MojaMetoda(double broj1, double broj2)
        {
            Console.WriteLine("MojaMetoda(double {0}, double {1})", broj1, broj2);
        }

        // Napisati statičku javno datupnu preopterećenu verziju metode MojaMetoda koja prima dva argumenta: prvi tipa int, a drugi tipa double. Metoda mora ispisati "MojaMetoda(int {0}, double {1})", broj1, broj2
        public static void MojaMetoda(int broj1, double broj2)
        {
            Console.WriteLine("MojaMetoda(int {0}, double {1})", broj1, broj2);
        }


        // Pokrenuti program i usporediti ispis sa prijašnjim.


        static void Main(string[] args)
        {
            int i1 = 1;
            int i2 = 2;
            double d1 = 3;
            double d2 = 4;

            MojaMetoda(i1, i2);
            MojaMetoda(i1, d1);
            MojaMetoda(d1, d2);
            MojaMetoda(d1, i2);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
