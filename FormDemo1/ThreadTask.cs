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


        //gloabal area
        public delegate void myDelegate1();
        public delegate void myDelegate2();
        public delegate void myDelegate3();


        public void myCallback1() {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(5);
                progressBar1.Value = i;
                Debug.Print("Thread 1 {0}",i);
            }
        }

        public void myCallback2()
        {
            for (int i=0; i<100; i++) {
                Thread.Sleep(5);
            progressBar2.Value = i;
                Debug.Print("Thread 2 {0}", i);
            }
            
        }

        public void myCallback3()
        {
            for (int i = 1; i <=100; i++)
            {
                progressBar3.Value = i;
            }
                
             
        }



        //events
        private void button1_Click(object sender, EventArgs e)
        {

            Thread t1 = new Thread(Berechnen1);
            t1.Name = "t1";
            t1.Start();      // Um Worker Thread (Parallel Thread) zu erzuegen, dass es 

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Thread t2 = new Thread(() =>
            {
                progressBar2.Invoke(new myDelegate2(myCallback2));
            });

            t2.Start();


        }


        private void button3_Click(object sender, EventArgs e)
        {
            Task task1 = new Task(()=> {

                for (int i = 0; i < 100; i++)
                {
                    progressBar3.Invoke(new myDelegate3(myCallback3));
                }
               
            });
            
            task1.Start();
          
        }


        //---------------------------------------------------------
        //methods
        public void Berechnen1()
        {

            progressBar1.Invoke(new myDelegate1(myCallback1));
          
        }



        public void Berechnen2()
        {

            progressBar2.Invoke(new myDelegate2(myCallback2));

        }


        //-------------------------------------------------------------------

    } //end of form class

}  // end of namespace
