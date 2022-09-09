using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kordamine_OOP.Koduloom;

namespace Kordamine_OOP
{
    class Hiir : Koduloom
    {
        public enum toug { Djungaria, Hiina, Süüria, Campbelli, Roborovski };
        public toug Toug;


        public Hiir(toug Toug, string nimi, string varv, sugu loomaSugu, double kaal, int vanus, bool elav) : base(nimi, varv, loomaSugu, kaal, vanus, elav)
        {
            this.Toug = Toug;
        }
        public Hiir(Hiir hiir)
        {
            this.Toug = hiir.Toug;
            this.nimi = hiir.nimi;
            this.varv = hiir.varv;
            this.loomaSugu = hiir.loomaSugu;
            this.kaal = hiir.kaal;
            this.vanus = hiir.vanus;
            this.elav = hiir.elav;

        }
        public override void print_Haal()
        {
            Console.WriteLine("Pi, Pipipipi");
        }

        public override void print_Info()
        {
            Console.WriteLine($"Toug:{Toug} hamsters.\nNimi: {nimi}\nVärv on {varv}\nTa on {loomaSugu} ja tema kaal on {kaal} gramm\n{vanus} aastat vana {elav}\n");
        }

        public void muudatNimi(string uusNimi) { nimi = uusNimi; }
        public void muudatVarv(string uusVarv) { varv = uusVarv; }
        public void muudatKaal(int uusKaal) { kaal = uusKaal; }
        public void muudatVanus(int uusVanus) { vanus = uusVanus; }
    }

}