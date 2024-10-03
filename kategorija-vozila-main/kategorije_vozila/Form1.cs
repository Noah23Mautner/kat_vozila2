using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kategorije_vozila
{

    
    public partial class Form1 : Form
    {
        List<Vozilo> voziloList = new List<Vozilo>();
        private int brojMotocikala = 0;
        private int brojAutomobila = 0;
        private int brojKamiona = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtboxModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                Vozilo novoVozilo = new Vozilo(txtboxModel.Text, int.Parse(txtboxGodinaproizvodnje.Text), int.Parse(txtboxBrojkotaca.Text));
                txtboxIspis.AppendText(novoVozilo.ToString() + Environment.NewLine);
                ModelVozila(novoVozilo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void ModelVozila(Vozilo vozilo)
        {
            if (vozilo.Broj_kotača == 2)
            {
                vozilo.Model = "Motocikl";
                 brojMotocikala++;
            }
            else if (vozilo.Broj_kotača == 4)
            {
                vozilo.Model = "Automobil";
                brojAutomobila++;
            }
            else if (vozilo.Broj_kotača > 4)
            {
                vozilo.Model = "Kamion";
                brojKamiona++;
            }
            else
            {
                throw new Exception("Neispravan broj kotača.");
            }

            txtboxIspis.AppendText("Kategorija: " + vozilo.Model + Environment.NewLine);
           
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            txtboxIspis.Clear(); // Clear the text box
            txtboxIspis.AppendText("model,Godina proizvodnje,broj kotača" + Environment.NewLine);

            foreach (Vozilo vozilo in voziloList)
            {
                txtboxIspis.AppendText(vozilo.ToString() + Environment.NewLine);
            }

            IspisUkupnogBroja();
            UpisiUCSV();
        }
        private void IspisUkupnogBroja()
        {
            txtboxIspis.AppendText("Ukupan broj motocikala: " + brojMotocikala + Environment.NewLine);
            txtboxIspis.AppendText("Ukupan broj automobila: " + brojAutomobila + Environment.NewLine);
            txtboxIspis.AppendText("Ukupan broj kamiona: " + brojKamiona + Environment.NewLine);
        }

        private void btn_Spremi_Click(object sender, EventArgs e)
        {
            
          
        }
        private void UpisiUCSV()
        {
            string putanja = "C:\\Users\\Ucenik\\Documents\\Testcsv\\vozilo.csv";
            using (StreamWriter writer = new StreamWriter(putanja))
            {
                writer.WriteLine("model,Godina proizvodnje,broj kotača");
                foreach (Vozilo vozilo in voziloList)
                {
                    writer.WriteLine($"{vozilo.Model},{vozilo.God_proizvodnje},{vozilo.Broj_kotača}");
                }
                writer.WriteLine($"Ukupan broj motocikala: {brojMotocikala}");
                writer.WriteLine($"Ukupan broj automobila: {brojAutomobila}");
                writer.WriteLine($"Ukupan broj kamiona: {brojKamiona}");
            }
            MessageBox.Show("Podaci su upisani u vozila.csv datoteku.");
        }
    }
}
