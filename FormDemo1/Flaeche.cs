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

namespace FormDemo1
{
    public partial class Flaeche : Form
    {

        public Flaeche()
        {
            InitializeComponent();
        }
        //---------------------------------------------------

        
        public class CKreis{


            //--------------Attributes can act as methods-----------------------------
           
            private Int32 radius;
            public Int32 Radius
            {
                get { return radius; }
                set {

                    radius = Convert.ToInt32(value);
                }
            }

            //--------------Attributes can act as methods-----------------------------

            private double flaeche;
            public double Flaeche {

                get { return flaeche; }

                set {

                   flaeche = System.Convert.ToDouble(Math.PI * Math.Pow(value, 2));
                }           
            }

            //--------------Attributes can act as methods-----------------------------


            private double umfang;
            public double Umfang {
                get { return umfang; }
                set {
                    umfang = 2 * Math.PI * value;
                }
            }


        } /*-------End of CKreis Class-----------*/

        //---------------------------------------------------     
        private void Flaeche_Load(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Aqua;
            button2.BackColor = System.Drawing.Color.Tomato;
            button3.BackColor = System.Drawing.Color.BlueViolet;          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CKreis kreis = new CKreis();
            try
            {

                kreis.Radius = System.Convert.ToInt32(textBox1.Text);

                richTextBox1.Text = kreis.Radius.ToString();
            }
            catch  {
                MessageBox.Show("Error, insert value");
            }

            }
            

        private void button2_Click(object sender, EventArgs e)
        {
            CKreis kreis = new CKreis();

            try
            {
                kreis.Flaeche = Convert.ToInt32(textBox1.Text);

                richTextBox1.Text = kreis.Flaeche.ToString();
            }
            catch {
                MessageBox.Show("insert value, please");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CKreis kreis = new CKreis();
            if (textBox1.Text !="") {
                kreis.Umfang = Convert.ToDouble(textBox1.Text);

                richTextBox1.Text = kreis.Umfang.ToString();

            }
            else {

                MessageBox.Show("Exception, insert value");
            }
          
        }
    }
}
