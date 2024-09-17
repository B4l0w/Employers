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
            List<Employers> dlista = new List<Employers>();
            StreamReader sr = new StreamReader("tulajdonsagok_100sor.txt");
            while (!sr.EndOfStream)
            {
                dlista.Add(new Employers(sr.ReadLine()));
            }
            foreach (var d in dlista)
            {
                Console.WriteLine(d.nev);
            }

            int legnagyobbi = 0;
            for (int i = 0; i < dlista.Count; i++)
            {
                if (dlista[i].kereset > dlista[legnagyobbi].kereset)
                {
                    legnagyobbi = i;
                }
            }
            Console.WriteLine("{0} , {1}",dlista[legnagyobbi].azonosito,  dlista[legnagyobbi].kereset);

            foreach (var d in dlista)
            {
                if (d.kor >= 55)
                {
                    Console.Write("{0}, ",d.nev);
                }
            }
            Console.ReadLine();
        }
    }
}
