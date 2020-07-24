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
    public partial class Schleifen : Form
    {
        public Schleifen()
        {
            InitializeComponent();
        }

       

        private void Schleifen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                listBox1.Items.Add(i + " " +  "viele Wege führen nach Rom !");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1;
            for (;  i<=5 ;)
            {
                listBox1.Items.Add(i + " " + "Viele Wege führen nach Rom !");
                
                i++;
            }
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <=5)
            {
                listBox1.Items.Add(i + " " + "Viele Wege führen nach Rom !");
                i++;
            }
        } 

        
        private void Löschen_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i=1; ; i++)
            {
                listBox1.Items.Add(i + " " + "Viele Wege führen nach Rom !");
                if (i==5) {break;}
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
