using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDemo1
{
    public partial class ParentChildMethod : Form
    {
        public ParentChildMethod()
        {
            InitializeComponent();
        }


        //-----------------------------------------------------

        public class FamilyClass
        {
            public static double GrandParentMethod(double a, double b)
            {
                return ParentMethod(a, b);                
            }

            public static double ParentMethod(double x, double y)
            {
                return ChildMethod(x, y);
            }
        
            public static double ChildMethod(double var1, double var2)
            {
            return var1 + var2;
            }

        } // end  of class


        //----------------------------------------------------------
            private void button1_Click(object sender, EventArgs e)
            {
                try {
                    double a = Convert.ToDouble(textBox1.Text);
                    double b = Convert.ToDouble(textBox2.Text);
                    double result = FamilyClass.GrandParentMethod(a, b);
                    listBox1.Items.Add(result.ToString("0.00"));
                }
                catch (Exception ex)
                {
                MessageBox.Show(ex.Message, "do insert values into text boxes");
                }
            }

     }  // end of form      
   } // end of namespace

