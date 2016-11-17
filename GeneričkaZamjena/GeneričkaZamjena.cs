using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class Program
    {
        static void ZamijeniGenerički<T>(ref T o1, ref T o2)
        {
            T temp = o2;
            o2 = o1;
            o1 = temp;
        }

        static void IspišiPar<T>(T o1, T o2)
        {
            Console.WriteLine("{0} - {1}", o1, o2);
        }

        static void Main(string[] args)
        {
            // Prevesti program i otvoriti i pogledati generirani kod s ILDASM alatom.

            int i1 = 5;
            int i2 = 10;
            IspišiPar(i1, i2);
            ZamijeniGenerički(ref i1, ref i2);
            IspišiPar(i1, i2);

            Console.WriteLine();

            double d1 = 1.23;
            double d2 = 4.56;
            IspišiPar(d1, d2);
            ZamijeniGenerički(ref d1, ref d2);
            IspišiPar(d1, d2);

            Console.WriteLine();

            string s1 = "Mirko";
            string s2 = "Slavko";
            IspišiPar(s1, s2);
            ZamijeniGenerički(ref s1, ref s2);
            IspišiPar(s1, s2);


            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
