using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DolgozoProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("adatok.txt");
            List<Dolgozo> dolgozok = new List<Dolgozo>();

            while (!sr.EndOfStream)
            {
                string[] adatok = sr.ReadLine().Split(' ');
                Dolgozo dolgozo = new Dolgozo(

                   adatok[0],
                   adatok[1],
                   adatok[2],
                   int.Parse(adatok[3]),
                   int.Parse(adatok[4])
                );
                dolgozok.Add(dolgozo);

            }

            Console.WriteLine("3. Feladat: " + dolgozok.Count + " darab dolgozó adata található");

            var atlagFizetes = dolgozok.Where(y => y.Kor < 25).ToList().Sum(x => x.Fizetes);
            Console.WriteLine("4. Feladat: " + atlagFizetes + " forint");

            var legnagyobbfizetesuDolgozo = dolgozok.OrderByDescending(x => x.Fizetes).First();
            Console.WriteLine("5. Feladat: \n A legnagyobb fizetésű dolgozó adatai: \n" + " Dolgozó neve: \t" + legnagyobbfizetesuDolgozo.Vezeteknev + " " + legnagyobbfizetesuDolgozo.Keresztnev + "\n" + " Neme: \t" + legnagyobbfizetesuDolgozo.Neme + "\n Életkora: \t" + legnagyobbfizetesuDolgozo.Kor + "\n Fizetése: \t" + legnagyobbfizetesuDolgozo.Fizetes + " Ft");

            Console.WriteLine("6. Feladat: Kérem adjon meg egy összeget:");
            int osszeg = int.Parse(Console.ReadLine());

            bool vanE = dolgozok.Any(x => x.Fizetes > osszeg);
            if (vanE)
            {
                Console.WriteLine("Van ilyen dolgozó, akinek a fizetése " + osszeg + " Ft felett van");
            }
            else
            {
                Console.WriteLine("Nincs ilyen dolgozó");

            }

            var diakok = dolgozok.Where(x => x.Kor < 18).ToList();
            StreamWriter sw = new StreamWriter("diakok.txt");
            
            foreach (var item in diakok)
            {
                sw.WriteLine(item.Vezeteknev + " " + item.Keresztnev + " " + item.Neme + " " + item.Kor + " " + item.Fizetes + " Ft");
            }
            sw.Close();
        }
    }
}
