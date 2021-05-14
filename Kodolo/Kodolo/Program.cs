using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Kodolo
{
    public class Kodolas
    {
        public int szam { get; private set; }
        public char karakter { get; private set; }

        public static List<Kodolas> collection = new List<Kodolas>();

        public Kodolas(char a)
        {
            szam = Convert.ToInt32(a);
            karakter = a;
        }

        public static string szamkodolo(List<Kodolas> a)
        {
            string szamkod = "";
            szamkod = a[0].szam.ToString();
            for (int i = 1; i < a.Count; i++)
                szamkod += (Convert.ToInt32(a[i].szam) - Convert.ToInt32(a[i - 1].szam)).ToString();

            return szamkod;

        }

        public static string karakterkodolo(List<Kodolas> a)
        {
            string karakterkod = "";
            foreach (var item in a)
                karakterkod += item.karakter;

            return karakterkod;
        }

    }
    public class Feldolgoz
    {
        static void Main(string[] args)
        {

            string szoveg;
            Console.Write("Gépelje be a szöveget: ");
            szoveg = Console.ReadLine();

            foreach (var elem in szoveg)
            {
                Kodolas.collection.Add(new Kodolas(elem));
            }

            Console.WriteLine(Kodolas.szamkodolo(Kodolas.collection));
            Console.WriteLine(Kodolas.karakterkodolo(Kodolas.collection));

        }
    }
}