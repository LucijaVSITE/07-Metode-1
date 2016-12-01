using System;

namespace Vsite.CSharp
{
    // Dodati metodu proširenja (extension method) BrojRiječi klasi string koja kao rezultat vraća broj riječi
    static class StringExtensions
    {
        public static int BrojRiječi(this string tekst) {
            return (tekst.Split(new char[] {'.',' ',',','?','!'}, StringSplitOptions.RemoveEmptyEntries)).Length;
        }
    }
    

    public class MetodeProširenja
    {
        public static int DajBrojRiječi(string tekst)
        {
            // Zamijenite povratnu vrijednost rezultatom metode proširenja BrojRiječi.
            return tekst.BrojRiječi();
        }

        static void Main(string[] args)
        {
            string s = "Kako je počeo rat na mom otoku?";
            Console.WriteLine("U '{0}' ima {1} riječi.", s, DajBrojRiječi(s));

            s = "Jedna, dva, tri!";
            Console.WriteLine("U '{0}' ima {1} riječi.", s, DajBrojRiječi(s));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
