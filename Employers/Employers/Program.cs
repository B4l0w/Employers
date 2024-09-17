using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Employers
{
    internal class Program
    {
        class Employers
        {
            public int azonosito;
            public string nev;
            public int kor;
            public int kereset;

            public Employers(string sor)
            {
                string[] emberek = sor.Split(';');
                this.azonosito = int.Parse(emberek[0]);
                this.nev = emberek[1];
                this.kor = int.Parse(emberek[2]);
                this.kereset = int.Parse(emberek[3]);
            }
        }
        static void Main(string[] args)
        {
            //Beolvasás
            List<Employers> dlista = new List<Employers>();
            StreamReader sr = new StreamReader("tulajdonsagok_100sor.txt");
            //Hozzáadás a listához
            while (!sr.EndOfStream)
            {
                dlista.Add(new Employers(sr.ReadLine()));
            }

            //Dolgozók kiíratása
            Console.Write("A dolgozók neve: ");
            foreach (var d in dlista)
            {
                Console.Write("{0}, ",d.nev);
            }
            Console.WriteLine("\n");

            //Legtöbbet kereső megkeresése
            int legnagyobbi = 0;
            for (int i = 0; i < dlista.Count; i++)
            {
                if (dlista[i].kereset > dlista[legnagyobbi].kereset)
                {
                    legnagyobbi = i;
                }
            }
            Console.WriteLine("Legtöbbet kereső azonosítója: {0} , neve: {1}\n",dlista[legnagyobbi].azonosito,  dlista[legnagyobbi].nev);


            //10 éven belül nyugdíjba vonuló emberek kiíratása
            Console.Write("Emberek akik 10 év múlva nyugdíjasak lesznek:");
            foreach (var d in dlista)
            {
                if (d.kor == 55)
                {
                    Console.Write(" {0}, ",d.nev);
                }
            }
            Console.WriteLine("\n");

            //Emberek akik 50.000 felett keresnek
            int otvenezerfelett = 0;
            foreach(var d in dlista)
            {
                if (d.kereset > 50000)
                {
                    otvenezerfelett++;
                }
            }
            Console.WriteLine("50000 felett kereső emberek száma: {0}",otvenezerfelett);
            Console.ReadLine();
        }
    }
}
