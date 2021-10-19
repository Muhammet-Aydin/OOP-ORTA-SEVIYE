using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_8POLİFORMIZM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnphone1_Click(object sender, EventArgs e)
        {
            Nokıa nk = new Nokıa();
            
            nk.Brand = "Nokıa";
            nk.UnitPrice = 2500;
            MessageBox.Show(nk.Brand + nk.UnitPrice);
            nk.CallSound();
 


        }

        private void btnphone2_Click(object sender, EventArgs e)
        {
            Samsung sm = new Samsung();
            sm.Brand = "Samsung";
            sm.UnitPrice = 5000;
            MessageBox.Show(sm.Brand + sm.UnitPrice);

            sm.CallSound();


        }

        private void btnphone3_Click(object sender, EventArgs e)
        {
            Iphone ıp = new Iphone();
            ıp.Brand = "Iphone";
            ıp.UnitPrice = 4000;

            MessageBox.Show(ıp.Brand + ıp.UnitPrice);


            ıp.CallSound();

        }

     
    }
}
