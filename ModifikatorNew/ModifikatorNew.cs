using System;

namespace Vsite.CSharp
{
    public class ModifikatorNew
    {
        public class Bazna
        {
            public void PredstaviSe()
            {
                Console.WriteLine("Bazna klasa");
            }
        }
        public class Izvedena : Bazna
        {
            // Dodajte javno dostupnu metodu void PredstaviSe() koja će ispisati "Izvedena klasa, izvedena iz:" te će pozvati PredstaviSe iz klase Bazna.
            public new void PredstaviSe()
            {
                Console.WriteLine("Izvedena klasa, izvedena iz:");
                base.PredstaviSe();
            }
        }

        static void Main(string[] args)
        {
            // Izvesti program i usporediti ispise.
            Bazna bazna = new Izvedena();
            bazna.PredstaviSe();

            Console.WriteLine();

            Izvedena i = new Izvedena();
            i.PredstaviSe();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
