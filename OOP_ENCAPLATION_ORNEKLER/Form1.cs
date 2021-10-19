using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ENCAPLATION_ORNEKLER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ürün ürn = new Ürün();
            ürn.Id =Convert.ToInt32(txt_ÜrünId.Text);
            ürn.Acıklama = txt_ÜrünAcıklama.Text;
            ürn.Fiyat = Convert.ToDouble(txt_ÜrünFiyat.Text);

           richTextBox1.Text = ($"{ürn.Id} {ürn.Acıklama} {ürn.Fiyat}");
          
        }
       

    }
}
