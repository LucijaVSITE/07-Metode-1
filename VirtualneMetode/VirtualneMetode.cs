using System;

namespace Vsite.CSharp
{
    class Bazna
    {
        public void IspišiImeObično()
        {
            Console.WriteLine("Bazna Obično");
        }

        public virtual void IspišiImeVirtualno()
        {
            Console.WriteLine("Bazna Virtualno");
        }
    }
    //U klase Izvedena1 i Izvedena2 dodajte javno dostupne metode 
    //IspišiImeObično koje će ispisati "Izvedena1 Obično", odnosno "Izvedena2 Obično". 
    //Pokrenite program i usporedite ispise s prijašnjima.
    class Izvedena1 : Bazna
    {
        public new void IspišiImeObično()
        {
            Console.WriteLine("Izvedena1 Obično");
        }
        public new virtual void IspišiImeVirtualno()
        {
            Console.WriteLine("Izvedena1 Virtualno");
        }
    }
    //U klase Izvedena1 i Izvedena2 dodajte javno dostupne metode
    //IspišiImeVirtualno koje će ispisati "Izvedena1 Virtualno",
    //odnosno "Izvedena2 Virtualno". Pokrenite program i usporedite ispise s prijašnjima.
    class Izvedena2 : Bazna
    {
        public new void IspišiImeObično()
        {
            Console.WriteLine("Izvedena2 Obično");
        }
        public new virtual void IspišiImeVirtualno()
        {
            Console.WriteLine("Izvedena2 Virtualno");
        }
    }

    public class VirtualneMetode
    {
        public static void ZasebniPoziviNevirtualnihMetoda()
        {
            Bazna bazna = new Bazna();
            bazna.IspišiImeObično();

            Izvedena1 izvedena1 = new Izvedena1();
            izvedena1.IspišiImeObično();

            Izvedena2 izvedena2 = new Izvedena2();
            izvedena2.IspišiImeObično();
        }

        public static void PoziviNevirtualnihMetodaNaKolekcijiBaznogTipa()
        {
            Bazna[] objekti = new Bazna[] { new Bazna(), new Izvedena1(), new Izvedena2() };
            foreach (Bazna o in objekti)
                o.IspišiImeObično();
        }

        public static void ZasebniPoziviVirtualnihMetoda()
        {
            Bazna bazna = new Bazna();
            bazna.IspišiImeVirtualno();

            Izvedena1 izvedena1 = new Izvedena1();
            izvedena1.IspišiImeVirtualno();

            Izvedena2 izvedena2 = new Izvedena2();
            izvedena2.IspišiImeVirtualno();
        }

        public static void PoziviVirtualnihMetodaNaKolekcijiBaznogTipa()
        {
            Bazna[] objekti = new Bazna[] { new Bazna(), new Izvedena1(), new Izvedena2() };
            foreach (Bazna o in objekti)
                o.IspišiImeVirtualno();
        }


        static void Main(string[] args)
        {
            // Pokrenite program i provjerite što će se ispisati.
//Zasebni pozivi nevirtualnih metoda:
//Bazna Obicno
//Bazna Obicno
//Bazna Obicno
//Pozivi nevirtualnih metoda na kolekciji baznih objekata:
//            Bazna Obicno
//Bazna Obicno
//Bazna Obicno
//Zasebni pozivi virtualnih metoda:
//Bazna Virtualno
//Bazna Virtualno
//Bazna Virtualno
//Pozivi virtualnih metoda na kolekciji baznih objekata:
//            Bazna Virtualno
//Bazna Virtualno
//Bazna Virtualno
//GOTOVO!!!
           

            Console.WriteLine("Zasebni pozivi nevirtualnih metoda:");
            ZasebniPoziviNevirtualnihMetoda();

            Console.WriteLine("Pozivi nevirtualnih metoda na kolekciji baznih objekata:");
            PoziviNevirtualnihMetodaNaKolekcijiBaznogTipa();

            Console.WriteLine("Zasebni pozivi virtualnih metoda:");
            ZasebniPoziviVirtualnihMetoda();

            Console.WriteLine("Pozivi virtualnih metoda na kolekciji baznih objekata:");
            PoziviVirtualnihMetodaNaKolekcijiBaznogTipa();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
