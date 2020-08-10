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
    public partial class SubClass : Form
    {
        public SubClass()
        {
            InitializeComponent();
        }

        // global area


        //Basisklasse
        public class CKunde
        {          
            public CKunde() { } //constructor of base class

            public CKunde(string anrede, string name) // überladener constructor
            {
                this._anrede = anrede;
                this._name = name;
            }


            private string _anrede;
            public string Anrede
            {
                get { return this._anrede; }
                set { this._anrede = value; }
            }            


            private string _name;
            public string Name
            {
                get { return _name; }
                set { this._name = value; }
            }
            

            private bool _stammkunde;
            public bool Stammkunde {
                get { return this._stammkunde; }
                set { this._stammkunde = value; }
            }

            public decimal _guthaben = 0;


            //methode
            public virtual string getAddress()
            {
                return this._anrede + " " + this._name;
            }

            //methode
            public virtual void addGuthaben(decimal betrag)
            {
                if (_stammkunde)
                {
                    this._guthaben += betrag;
                }
                
            }

        } // -----end---of--class--CKunde------


        //Subklasse
        public class CPrivatKunde : CKunde
        {
            private string wohnort;

            public CPrivatKunde() { } // constructor
            public CPrivatKunde(string anrede, string name, string ort):base(anrede, name) 
            {
                this.Anrede = anrede;
                this.Name = name; 
                this.wohnort = ort;
            }

            public override string getAddress()
            {

                return base.getAddress() + " " + "aus" + " " + this.wohnort;
            }

            public override void addGuthaben(decimal betrag)
            {
                _guthaben += 0.05M * betrag;
            }


        }  // end-----of------class-CPrivatKunde----


//----------------------------------------------------------------------------------//
        private void SubClass_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("test");
        }


        //----------------------------------
        private void button1_Click(object sender, EventArgs e)
        {

            CPrivatKunde privatkunde = new CPrivatKunde("Herr","Friedrich","Lübeck");

            label3.Text = privatkunde.getAddress();

            try {
                Decimal a = Decimal.Parse(textBox1.Text);
                privatkunde.addGuthaben(a);
                label5.Text = privatkunde._guthaben.ToString() + " " + "€";
            }
            catch (Exception ex)
            {
              //MessageBox.Show(ex.Message + " " + Environment.NewLine + "Please, do insert value");
                MessageBox.Show(ex.Message + " " + (char)10 + "Please, do insert value");
            }
        }
    }
}
