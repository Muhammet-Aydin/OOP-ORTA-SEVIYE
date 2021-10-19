using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_CONSTRUCTOR_ORNEK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ARABA OBJESI OLUSTUR İÇİNDE MARKA MODEL MOTORGUCU
        //BU BİLGİLERİ NEWLERKEN VEREBİLMEL İSTİYORUZ.

        
        private void Form1_Load(object sender, EventArgs e)
        {
          Araba rb = new Araba("bmw", "5.20i", 2.5f);
          Araba rb2 = new Araba("mercedes", "amg", 3.4f);


            this.Text = rb.marka;
        }
    }
}
