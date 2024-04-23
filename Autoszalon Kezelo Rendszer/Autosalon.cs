using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autószalon_Kezelő_Rendszer
{
    internal class Autosalon
    {
        public List<Jarmu> Jarmuvek { get; set; }
        public Autosalon()
        {
            Jarmuvek = new List<Jarmu>();
        }
        public void UjJarmuHozzaadasa(Jarmu jarmu)
        {
            Jarmuvek.Add(jarmu);
            Console.WriteLine("Sikeresen hozzáadva a listához.");

        }
        public bool JarmuEladasa(string gyarto, string modell)
        {
            Jarmu eladas = JarmuKeresese(gyarto, modell);

            if (eladas != null)
            {
                Jarmuvek.Remove(eladas);
                return true;
            }
            return false;
        }
        public Jarmu JarmuKeresese(string gyarto, string modell)
        {
            foreach (var item in Jarmuvek)
            {
                if (item.Gyarto == gyarto && item.Modell == modell)
                {
                   return item;
                }
            }
            return null;
        }

        public void JarmuvekListazasa()
        {
            foreach (var item in Jarmuvek)
            {
                item.JarmuInfo();
            }
        }
    }
}
