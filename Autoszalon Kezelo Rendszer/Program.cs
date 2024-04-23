using Autószalon_Kezelő_Rendszer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszalon_Kezelo_Rendszer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autosalon jarmuvek = new Autosalon();
            Szemelyauto jarmu = new Szemelyauto("Toyota", "Corolla", 2021, 8000000, 15000, 5, "Fehér", 66544);
            jarmuvek.UjJarmuHozzaadasa(jarmu);

            Terepjaro terep = new Terepjaro("Land Rover", "Defender", 2020, 15000000,"4WD",true,2,35000);
            jarmuvek.UjJarmuHozzaadasa(terep);

            jarmuvek.JarmuvekListazasa();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("eladás");

            bool sikeres = jarmuvek.JarmuEladasa("Toyota", "Corolla");
            Console.WriteLine($"Autó eladása: {sikeres}");

            Jarmu defender = jarmuvek.JarmuKeresese("Land Rover", "Defender");
            if (defender != null)
            {
                Console.WriteLine("Az autó megvan");
                defender.JarmuInfo();
            }
            else
            {
                Console.WriteLine("Az autó nincs meg");
            }

            Console.WriteLine("Járművek listázása");
            jarmuvek.JarmuvekListazasa();

            if (defender != null)
            {
                Terepjaro landRover = (Terepjaro)defender;
                landRover.OffroadCsomagFelszerel();
                landRover.KmAllasFrissites(200);

                int premiumHangrendszer = 50000000;
                int napfenyteto = 2500000;

                int ar = landRover.ArKalkulacio() + premiumHangrendszer + napfenyteto;

                Console.WriteLine("Ár: " + landRover.ArKalkulacio());
                Console.WriteLine("Hangrendszer: " + premiumHangrendszer);
                Console.WriteLine("Napfénytető: " + napfenyteto);
                Console.WriteLine("Összesen: " + ar);
            }
        }
    }
}
