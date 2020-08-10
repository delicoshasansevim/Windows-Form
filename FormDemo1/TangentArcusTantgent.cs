using System;
using System.CodeDom.Compiler;
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
    public partial class TangentArcusTantgent : Form
    {
        public TangentArcusTantgent()
        {
            InitializeComponent();
        }


        //-------------------------------------------

        public static double radiant;
        public static double tangent { get; set; }

        CTangentBerechnung tangentberechnung = new CTangentBerechnung();

        //--------------------------------------
        public class CTangentBerechnung {

            public double CTangentMethode(double winkel) {

                radiant = Math.PI / 180 * winkel;
                tangent = Math.Tan(radiant);
                return tangent;
            }

            public double CArcusTangentMethode()
            {
                double temp = TangentArcusTantgent.tangent;

                return Math.Atan(temp);
            }

           
        } // end of class

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            
                double tangent_result = tangentberechnung.CTangentMethode(Convert.ToDouble(textBox1.Text));
                label1.Text = tangent_result.ToString();
                textBox2.Text = tangent_result.ToString();
                //  label1.Text  = Math.Tan(0.52359).ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = tangent.ToString();
                
            label4.Text = tangentberechnung.CArcusTangentMethode().ToString();
        }
    }
}
