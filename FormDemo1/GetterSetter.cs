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
    public partial class GetterSetter : Form
    {
        public GetterSetter()
        {
            InitializeComponent();
        }


        // global area-----------------------------------------------------//

        

        public class CKreis
        {
       

            public CKreis() { }         // KONSTRUCKTOR

            private double radius;
            public double Radius    // Ptoperty Radius
            {
                get
                {                                  //get method of property
                    return radius;     
                }
                set {                              //set method of property             
                    this.radius = value;
                }
            }


           
           public double Umfang   // Property Umfang
            {
                get { return 2 * Math.PI * radius; }
                set 
                {
                    if (value != 0)
                    {
                        radius = Convert.ToDouble(value) / 2 / Math.PI;
                    }
                }
            }


            public double flaeche
            {
                get { return Math.PI * Math.Pow(radius, 2); }   //get method
                      
                
                set {                                              //set method
                    if (value != 0)
                    {
                        radius = Math.Sqrt(Convert.ToDouble(value) / Math.PI);
                    }
                    else {
                        radius = 0;
                    }
                }
            }


        } // end--of class--CKreis


        CKreis kreis = new CKreis();   // global object for all event handlers

        //-------------------------EVENT Handler-----------------------------------//
        private void GetterSetter_Load(object sender, EventArgs e)
        {
            // implent me
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try {
                kreis.Radius = Convert.ToDouble(textBox1.Text);
                textBox2.Text = kreis.Umfang.ToString();
                textBox3.Text = kreis.flaeche.ToString();
            }
            catch (Exception ex) {
               // MessageBox.Show(ex.Message);
            }

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            
            try {
                kreis.Umfang = double.Parse(textBox2.Text);
                textBox1.Text = kreis.Radius.ToString();
                textBox3.Text = kreis.flaeche.ToString();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }

        }
            
        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                kreis.flaeche = double.Parse(textBox3.Text);
                textBox2.Text = kreis.Umfang.ToString();
                textBox1.Text = kreis.Radius.ToString();
              
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }
    }
}
