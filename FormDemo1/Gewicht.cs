using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDemo1
{
    public partial class Gewicht : Form
    {
        public Gewicht()
        {
            InitializeComponent();
        }

        //Class
        public class CKugel{

            public double radius;
            public double spezifischesGewicht;
        }

        // Gloabal variable
        double gewicht;

        // getKugel() globale Methode um die Variablen zu initialisieren
        public CKugel GetKugel()
        {
            CKugel kugel = new CKugel();

            // um die Variable `spezifischesGewicht` mit Bedingung zuzuweisen
            if (this.radioButton1.Checked) { kugel.spezifischesGewicht = 1.40; } //Holz
            else if (this.radioButton2.Checked) { kugel.spezifischesGewicht = 2.70; } // Alu
            else if (this.radioButton3.Checked) { kugel.spezifischesGewicht = 3.80; } // Glas
            else if (this.radioButton4.Checked) { kugel.spezifischesGewicht = 7.87; } // Eisen
            else if (this.radioButton5.Checked) { kugel.spezifischesGewicht = 2.70; } // Blei

            // auch radius globale variable soll initialisiert werden um die exception auszuschliessen
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("pleae, insert value for radius");
            }
            else {
                //hier mit dem Wert vom `textBox1` zuweisen
                kugel.radius = System.Convert.ToDouble(textBox1.Text);
            }


            return kugel;
        }

        //----------------------------------------

        //KugelGewicht´() funktion um eine mathematische Operation durchzuführen // ohne Rückgabewert
        public void KugelGewichtBerechnung(CKugel kugel)
        {
            double temp_volume = (4 / 3) * Math.PI * Math.Pow(kugel.radius, 3);

            this.gewicht = temp_volume * kugel.spezifischesGewicht;
        }

        //----------------------------------------

        //KugelGewicht´() funktion um eine matematische Operation durchzuführen // mit Rückgabewert
        public double KugelGewichtBerechnung(double radiusParam, double spezifischeGewichtParam)
        { 
        
         double temp_volume = (4 / 3) * Math.PI * Math.Pow(radiusParam, 3);

            return (temp_volume * spezifischeGewichtParam);
        }

        //----------------------------------------

        //Kugelgewicht() mit Referenz Übergabe
        public void KugelGewichtBerechnung(ref CKugel kug )
        {
            double volume = (4 / 3) * Math.PI * Math.Pow(kug.radius, 3);
            kug.spezifischesGewicht = volume * kug.spezifischesGewicht ;
        }

        private void Gewicht_Load(object sender, EventArgs e)
        {
          
        }

       // Methode ohne Rückgabewert
        private void button1_Click(object sender, EventArgs e)
        {
            // Damit alle variable initialisiert werden, die getKugel() Methode aufrufen und Rückgabe als Objekt auf CKugel zu speichern
            CKugel kugel = GetKugel();
            // dieses Objekt soll als parameter an die Methode weitergeleitet werden um die mathematische Operation mit den Werten von diesem Objekt durchzuführen
            KugelGewichtBerechnung(kugel);
            // weil die das Ergebnis der mathematische Operation von der Methode auf globale Variable `gewicht` gespeichert wurde, wird diese gloabale Variable `gewicht` hier auf den Bildschirm gestellt
            Ergebnis.Text = this.gewicht.ToString();
        }

        //Methode mit Rückgabewert
        private void button2_Click(object sender, EventArgs e)
        {
            // Damit alle variable initialisiert werden, die getKugel() Methode aufrufen und Rückgabe als Objekt auf CKugel zu speichern
            CKugel kugel = GetKugel();

            double radius = kugel.radius;
            double spezifischesGewicht = kugel.spezifischesGewicht;

            double gew = KugelGewichtBerechnung(radius, spezifischesGewicht);
            Ergebnis.Text = gew.ToString();        

        }


        //Methode Aufrf mit Referenz
        private void button3_Click(object sender, EventArgs e)
        {
            

            CKugel kug = GetKugel();

            KugelGewichtBerechnung(ref kug);

            Ergebnis.Text = kug.spezifischesGewicht.ToString();
        }
    }
}
