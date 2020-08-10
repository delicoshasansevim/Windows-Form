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
    public partial class StaticElement : Form
    {
        public StaticElement()
        {
            InitializeComponent();
        }

        // Global area
        public class CMeineFormeln
        {
            //method 
            public static double KugelVolumen(double radius)
            {
                return (4/3) * Math.PI * Math.Pow(radius, 3);
            }

            //method
            public static double Kreisumfang(double radius)
            {
                return 2 * Math.PI * radius;
            }

            //method
            public static double Nettoberechnung(double brutto, double mwst) {

                return brutto / System.Convert.ToDouble(1 + mwst);
;            }

        
        } // end-of-class---------------

        private void StaticElement_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            double radius = Convert.ToDouble(textBox1.Text);
            double Brutto = System.Convert.ToDouble(textBoxBrutto.Text);
          
                textBoxKreiumfang.Text = CMeineFormeln.Kreisumfang(radius).ToString("0.000");

                textBoxKugelvolumen.Text = CMeineFormeln.KugelVolumen(radius).ToString("0.000");

                textBoxNetto.Text = CMeineFormeln.Nettoberechnung(Brutto, 0.19).ToString("0.000");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message + "!!! please, insert to input boxes");
            }
        }
    }
}
