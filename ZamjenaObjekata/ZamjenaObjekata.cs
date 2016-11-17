using System;

namespace Vsite.CSharp
{
    public class ZamjenaObjekata
    {
        // Promijeniti metodu tako da se zamjena odrazi u pozivajućem kodu.
        static void Zamijeni(ref object s1,ref object s2)
        {
            object temp = s2;
            s2 = s1;
            s1 = temp;
        }

        public static void ZamjenaStringova(string prvi, string drugi)
        {
            Console.WriteLine("Prije metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);

            object prviS = prvi;
            object drugiS = drugi;
            Zamijeni(ref prviS,ref drugiS);
            prvi = (string)prviS;
            drugi = (string)drugiS;

            Console.WriteLine("Nakon metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);
        }

        public static void ZamjenaIntova(int prvi, int drugi)
        {
            Console.WriteLine("Prije metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);

            object prviS = prvi;
            object drugiS = drugi;
            Zamijeni(ref drugiS, ref prviS);
            prvi =(int) prviS;
            drugi =(int)drugiS;

            // Promijeniti metodu Zamijeni tako da umjesto tipa string prima tip object i tako podržava zamjenu bilo kojeg tipa objekta. Dodati poziv te metode za 2 argumenta tipa int te provjeriti funkcionalnost.


            Console.WriteLine("Nakon metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);
        }

        static void Main(string[] args)
        {
            string prvi = "prvi";
            string drugi = "drugi";

            ZamjenaStringova(prvi, drugi);

            Console.WriteLine();

            ZamjenaIntova(1, 2);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
