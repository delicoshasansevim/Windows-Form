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
    public partial class Debugging : Form
    {
        public Debugging()
        {
             InitializeComponent();
        }

        private void Debugging_Load(object sender, EventArgs e)
        {
         
            Button btn = new Button();

            btn.Size = new Size(200,50);
            btn.Text = "some Button C#";
            btn.Font = new Font("bold", 12.5f);

            btn.BackColor = Color.Aquamarine;

            btn.Location = new Point(105,61);

            btn.Click += new EventHandler(someFunction);
   
            this.Controls.Add(btn);

         
           // ImageList photoList = new ImageList();
           // photoList.ImageSize = new Size(200, 200);
           //photoList.Draw(g, new Point(20, 20));
           // photoList.Images.Add(Image.FromFile(@"C:\Users\Hasan Sevim\source\repos\FormDemo1\FormDemo1\Resources\background2.jpg"));


            Image img = new Bitmap(@"C:\Users\Hasan Sevim\source\repos\FormDemo1\FormDemo1\Resources\kardesler.jpg" );
      
            Graphics grapfic = Graphics.FromImage(img);
          //Point point = new Point(50,50);
            grapfic.DrawImage(img,200,200,50,50);
            pictureBox1.Image = img;

            
        }

        private Image resizeImage(Image img, Size size)
        {
            throw new NotImplementedException();
        }

        public void someFunction(Object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }


        private void button1_Click(object sender, EventArgs e)
        {
          
            /*for (int i = 1; i <= 10;  i++)
            {
                listBox1.Items.Add(i + "."+ "text");
            }*/
            

            string[,] tempArray = new string[3,2];
            tempArray[0, 0] = "Ankara";
            tempArray[0, 1] = "Izmir";
          
            tempArray[1, 0] = "Istanbul";
            tempArray[1, 1] = "Rize";

            tempArray[2, 0] = "Samsun";
            tempArray[2, 1] = "Mersin";



            for (int i = 0; i < 3 ; i++)
            {
                for (int k =0 ; k < 2 ; k++)
                {
                    listBox1.Items.Add((i) + (k) + "." + tempArray[i, k].ToString());
                }
                          
            }

            label1.Text = "Mühltal ist eine schöne " + Environment.NewLine + "Stadt mit Blumen";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
