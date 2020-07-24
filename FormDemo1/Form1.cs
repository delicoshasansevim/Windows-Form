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
    public partial class Form1 : Form
    {

     
        public Form1()
        {
            InitializeComponent();         
        }

        //global area
        double kurs = 1;
        double euro = 1;
        double dolar =1;
        


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = kurs.ToString();
            textBox2.Text = euro.ToString();
            textBox3.Text = dolar.ToString();
        }

        // kurs
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
           
           
            kurs = System.Convert.ToDouble(textBox1.Text);
            dolar = euro * kurs;
            textBox3.Text = dolar.ToString();
         
        }
    
   
      
        private void berechnung_Click(object sender, EventArgs e)
        {
            

            /* if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
             {
                 kurs = System.Convert.ToDouble(textBox1.Text);
                 euro = Convert.ToDouble(textBox2.Text);
                 double result = kurs * euro;
                 this.textBox3.Text = result.ToString();

                 Ergebnis.Text = System.Convert.ToString(result);

             }
             else if(textBox1.Text != "" && textBox2.Text == "" && textBox3.Text != "")
             {
                 kurs = System.Convert.ToDouble(textBox1.Text);
                 dolar = System.Convert.ToDouble(textBox3.Text);
                 double result = dolar / kurs;
                 this.textBox2.Text = System.Convert.ToString(result);

                 Ergebnis.Text = System.Convert.ToString(result);

             }
             else if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text != "")
             {

                 dolar = System.Convert.ToDouble(textBox3.Text);
                 euro = Convert.ToDouble(textBox2.Text);
                 double result = dolar / euro;

                 this.textBox1.Text = System.Convert.ToString(result);                
                 Ergebnis.Text = System.Convert.ToString(result);

             }
             else  {
                 MessageBox.Show("please, insert into two boxes ");
             }
 */
        }

        private void Schlissen_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

           
            euro = System.Convert.ToDouble(textBox2.Text);
            dolar = euro * kurs;
            textBox3.Text = dolar.ToString();
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            dolar = System.Convert.ToDouble(textBox3.Text);
            euro = dolar / kurs;
            textBox2.Text = euro.ToString();
        }
    }
}
