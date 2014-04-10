using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vjezbeKlasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // kreiranje novog objekta klase Automobil
            Automobil noviAutomobil = new Automobil();
            // popunjavanje svojstva i polja
            noviAutomobil.naziv = "Jetta";
            noviAutomobil.tezina = 1300;
            noviAutomobil.visina = 1430;
            noviAutomobil.duzina = 4644;
            noviAutomobil.meduosovinskiRazmak = 2651;
            noviAutomobil.gume = "195/65/15";
            noviAutomobil.co2 = 119;
            noviAutomobil.volumenPrtljaznika = 510;
            noviAutomobil.ncap = 5;
            noviAutomobil.vrata = 4;
            noviAutomobil.prednjeKocnice = "diskovi";
            noviAutomobil.zadnjeKocnice = "bubanj";
            // kreiranje novog objekta klase

            IDio motor = Motor(4, 1600, 105, "dizel");
            motor.naziv = "Motor TDI";
            motor.sifra = 17;
            // dodavanje novog objekta klase dio u automobil - polimorfizam
            noviAutomobil.addDio(motor);
            // dodavanje novog objekta klase mjenjač u obliku neimenovanog objekta (u jednoj liniji koda - one liner)
            noviAutomobil.addDio(new Mjenjac (6,"rucni") {naziv = "Mjenjac", sifra = 12 });

            // prolaz kroz kolekciju djelova i ispis njihovih naziva
            // primjetite da se neovisno o objektu (klase Motor ili Mjenjac) poziva ista metoda
            foreach (AutomotiveClasses.Dio d in noviAutomobil.getDjelovi())
            {
                rtbMain.AppendText(d.naziv + " - " + d.printAttributes() + "\n");
            }
            rtbMain.AppendText("VIN: " + noviAutomobil.idAutomobila.getVin());

        }
    }
}

