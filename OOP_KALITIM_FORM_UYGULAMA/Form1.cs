using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_KALITIM_FORM_UYGULAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BasePhone bsphn = new BasePhone();
            MobilePhone mbl = new MobilePhone(true, false, "Nokıa", "wireless");

            
        }
    }
}
