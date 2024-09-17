using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            
            StreamReader sr = new StreamReader("tulajdonsagok_100sor.txt");
            
        }
    }
}
