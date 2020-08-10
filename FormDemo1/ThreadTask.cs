using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDemo1
{
    public partial class ThreadTask : Form
    {
        public ThreadTask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*  for (int i = 0; i <= 100; i++)
              {
                  Thread.Sleep(100);

                  progressBar1.Value = i;
              }*/

            /*  var t1 = new Thread(new ThreadStart(Berechnen1));
              t1.Start();*/

            Thread t1 = new Thread(Berechnen1);
            t1.Name = "t1";
            t1.Start();      // Um Worker Thread (Parallel Thread) zu erzuegen, dass es 

        }


        private void button2_Click(object sender, EventArgs e)
        {


        }

        //---------------------------------------------------------

        public void Berechnen1()
        {

            for (int i = 1; i <= 2; i++)
            {
                Thread.Sleep(1000);
                Monitor.Enter(this);
               progressBar1.Value = i;
                
                //Debug.Print("Thread {0}", Thread.CurrentThread.Name);
            }
                 Monitor.Exit(this);
        }


//-------------------------------------------------------------------

    } //end of form class

}  // end of namespace
