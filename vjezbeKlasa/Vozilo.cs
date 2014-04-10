using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbeKlasa
{
    public abstract  class Vozilo
    {
        private List<IDio> montiraniDjelovi;
        public Win idAutomobila;
        public String naziv { get; set; }
        public int status { get; set; }
        public int tezina { get; set; }
        public int visina { get; set; }
        public int duzina { get; set; }
        public int meduosovinskiRazmak { get; set; }
        public String gume { get; set; }
        public int co2 { get; set; }

        public Vozilo()
        {
            montiraniDjelovi = new List<IDio>();
            idAutomobila = new Win(10, 15, 54);
        }
        public bool addDio(IDio noviDio)
        {
            montiraniDjelovi.Add(noviDio);
            return true;
        }
        public void updateStatus()
        {
            status = status++;
        }
        public List<IDio> getDjelovi()
        {
            return montiraniDjelovi;
        }
    }
}

    


