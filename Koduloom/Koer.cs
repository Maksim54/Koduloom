using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP
{
    class Koer : Koduloom
    {
        //public string toug_;//tõug - порода
        public enum toug { Mops, Pudel, Taksa, Mastif };
        public toug Toug;
        public Koer(toug Toug, string nimi, string varv, sugu loomaSugu, double kaal, int vanus, bool elav) : base(nimi, varv, loomaSugu, kaal, vanus, elav)
        {
            this.Toug = Toug;
        }
        public Koer(string nimi, string varv)
        {
            this.nimi = nimi;
            this.varv = varv;
        }
        public Koer(Koer koer)//kloonimiseks
        {
            this.Toug = koer.Toug;
            this.nimi = koer.nimi;
            this.varv = koer.varv;
            this.loomaSugu = koer.loomaSugu;
            this.kaal = koer.kaal;
            this.vanus = koer.vanus;
            this.elav = koer.elav;
        }

        public override void print_Haal()
        {
            Console.WriteLine("Au, Auuuuuu");
        }

        public override void print_Info()
        {
            Console.WriteLine($"Toug:{Toug}\nVärv:{varv} \nNimi: {nimi}\nTa on {loomaSugu} ja tema kaal on {kaal} kg\n{vanus} aastat vana\n");
        }
        public void muudaNimi(string uusNimi) { nimi = uusNimi; }
        public void muudaVarv(string uusVarv) { varv = uusVarv; }
        public void muudaKaal(int uusKaal) { kaal = uusKaal; }
        public void muudaVanus(int uusVanus) { vanus = uusVanus; }
    }
}