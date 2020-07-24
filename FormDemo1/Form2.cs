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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //global field
        double a;
        double b;
        double c;
        double temp;

        private void Form2_Load(object sender, EventArgs e)
        {

            Image resim = new Bitmap(@"C:\Users\Hasan Sevim\Pictures\background4.jpg");
            this.BackgroundImage = resim;

         

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                a = Convert.ToDouble(this.textBox1.Text);
                temp = a;


                b = System.Convert.ToDouble(textBox2.Text);
                if (b > temp) { temp = b; }

                c = System.Convert.ToDouble(this.textBox3.Text);
                if (c > temp) { temp = c; }

                berechnung.Text = "Maximum digit is: " + temp.ToString();
            }
            else {

                berechnung.Text = "Alle felder füllen bitte: " + temp.ToString();
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Datepicker
            button2.Text = this.dateTimePicker1.Value.ToString();
        }
    }
}
