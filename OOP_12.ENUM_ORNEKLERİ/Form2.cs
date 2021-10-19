using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_12.ENUM_ORNEKLERİ
{
    public enum Günler:byte
    {
    pazartesi=1,salı,carsamba,persembe,cuma,cumartesi,pazar
    
    }
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(Enum.GetNames(typeof(Günler)));
        }

        private void btnenum_Click(object sender, EventArgs e)
        {
            byte textgelendeger =byte.Parse(textBox1.Text);
            Günler gnlr = (Günler)textgelendeger;
            MessageBox.Show(gnlr.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Enum içerisinde var olan degerlin kontrolünü saglamk için "isDefined" metodu kullanılır.

            byte enumdegeri = byte.Parse(textBox1.Text);
            if (Enum.IsDefined(typeof(Günler),enumdegeri))
            {
                Günler günler=(Günler)enumdegeri;

                MessageBox.Show(günler.ToString());

            }
            else
            {
                MessageBox.Show("girdiniginiz index nuamrasına sabıt herhang br sehır bilgisine ulasılmadı.");
            }
        }
    }
}
