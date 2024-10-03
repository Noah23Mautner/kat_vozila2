using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kategorije_vozila
{
    internal class Vozilo
    {
        string model;
        int god_proizvodnje, broj_kotača;

        public Vozilo(string model, int god_proizvodnje, int broj_kotača)
        {
            this.Model = model;
            this.God_proizvodnje = god_proizvodnje;
            this.Broj_kotača = broj_kotača;
        }

        public string Model { get => model; set => model = value; }
        public int God_proizvodnje { get => god_proizvodnje; set => god_proizvodnje = value; }
        public int Broj_kotača { get => broj_kotača; set => broj_kotača = value; }

        public override string ToString()
        {
           // return base.ToString();

            return $"Model: {Model}\nGodina proizvodnje: {God_proizvodnje}\nBroj kotača: {Broj_kotača}";
        }
    }

}
