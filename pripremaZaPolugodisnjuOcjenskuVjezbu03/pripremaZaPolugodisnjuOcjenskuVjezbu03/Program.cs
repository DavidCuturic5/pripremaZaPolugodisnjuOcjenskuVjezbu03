using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripremaZaPolugodisnjuOcjenskuVjezbu03
{
    internal class Program
    {
        class Neboder
        {
            int visina;
            int brojKatova;


            private int Visina { get => visina; set => visina = value; }
            private int BrojKatova { get => brojKatova; set => brojKatova = value; }



            public Neboder() { }


            public Neboder(int visina, int brojKatova)
            {
                this.visina = visina;
                this.brojKatova=brojKatova;
            }


            public override string ToString()

            {
                string ispis = "Visina nebodera je " + (this.visina + 10) + " m" + "," + "broj katova je " + (this.brojKatova + 1) +
                    "\nProsječna visina kata je " + (this.visina / this.brojKatova) + " m";
                return ispis;
            }



        }



        static void Main(string[] args)
        {

            Neboder Tower = new Neboder(200, 100);

            Console.WriteLine(Tower.ToString());
            Console.ReadKey();
        }
    }
}
