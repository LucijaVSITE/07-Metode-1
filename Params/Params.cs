using System;

namespace Vsite.CSharp
{

    public class Params
    {
        // Napisati implementaciju metode tako da vrati zbroj svih proslijeđenih argumenata
        public static double Zbroji(params double[] pribrojnici)
        {
            double zbroj = 0.0;
            foreach (double broj in pribrojnici) {
                zbroj += broj;
            }
            return zbroj;
        }

        static void Main(string[] args)
        {
            double zbroj = Zbroji(1, 2, 3, 4);
            Console.WriteLine(zbroj);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

    }
}
