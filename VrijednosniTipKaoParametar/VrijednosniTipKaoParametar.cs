using System;

namespace Vsite.CSharp
{
    public class VrijednosniTipKaoParametar
    {
        // Pokrenuti program i provjeriti ispis.

        static void Uvećaj(int n)
        {
            n += 1;
            Console.WriteLine("U metodi Uvećaj: {0}", n);
        }

        public struct Osoba
        {
            public Osoba(string ime, int matičniBroj)
            {
                Ime = ime;
                MatičniBroj = matičniBroj;
            }

            public string Ime;
            public int MatičniBroj;

            public override string ToString()
            {
                return string.Format("Ime: {0}, MB: {1}", Ime, MatičniBroj);
            }
        }

        public static void PromijeniOsobu(Osoba o)
        {
            Console.WriteLine("U metodi PromijeniOsobu stavljam novu osobu:");
            o = new Osoba("Pero", 2);
            Console.WriteLine(o);
            Console.WriteLine("Nakon povratka iz metode PromijeniOsobu:");
        }

        public static void PromijeniIme(Osoba o, string novoIme)
        {
            Console.WriteLine(string.Format("U metodi PromijeniIme mijenjam ime u {0}", novoIme));
            o.Ime = novoIme;
            Console.WriteLine(o);
            Console.WriteLine("Nakon povratka iz metode PromijeniIme:");
        }

        static void Main(string[] args)
        {

            int n = 5;
            Console.WriteLine("Prije metode Uvećaj: {0}", n);

            Uvećaj(n);

            Console.WriteLine("Nakon metode Uvećaj: {0}", n);

            Console.WriteLine();

            // Ispod sljedeće naredbe dodati poziv metode PromijeniOsobu s prosljeđenom osobom janko i ispisati osobu nakon poziva te metode.
            Osoba janko = new Osoba("Janko", 1);
            PromijeniOsobu(janko);
            Console.WriteLine(janko);
            Console.WriteLine();

            // Napisati poziv metode PromijeniIme s prosljeđenom osobom janko i novim imenom "Pero" i ispisati osobu nakon poziva te metode.
            PromijeniIme(janko,"Pero");
            Console.WriteLine(janko);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
