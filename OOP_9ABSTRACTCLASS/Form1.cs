using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_9ABSTRACTCLASS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gitar gitar = new Gitar();
            gitar.Markasi = "abc";
            gitar.Aciklamasi = "asgfa";
            string ses=gitar.Cal();

            Muzisyen mz = new Muzisyen();
            mz.Ad = "muhammet";
            mz.Soyad = "aydın";
            mz.caldıgıalet = gitar;

            MessageBox.Show(string.Format(@"Calan kısının adı:{0},calan kısının soyadı:{1},Çaldıgı aletın markası:{2},Çaldıgı ses:{3}", mz.Ad,mz.Soyad,mz.caldıgıalet.Markasi,ses));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            YanFlüt yn = new YanFlüt();
            yn.Markasi = "asdghm";
            yn.Aciklamasi = "tgdhfj";
            string ses2 = yn.Cal();

            Muzisyen mz = new Muzisyen();
            mz.Ad = "ryrt";
            mz.Soyad = "sdgd";
            mz.caldıgıalet = yn;
            MessageBox.Show(string.Format(@"Calan kısının adı:{0},calan kısının soyadı:{1},Çaldıgı aletın markası:{2},Çaldıgı ses:{3}", mz.Ad, mz.Soyad, mz.caldıgıalet.Markasi, ses2));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bateri btr = new Bateri();
            btr.Markasi = "retyuıu";
            btr.Aciklamasi = "retyu";
            string ses3 = btr.Cal();


            Muzisyen mz = new Muzisyen();
            mz.Ad = "";
            mz.Soyad = "";
            mz.caldıgıalet = btr;

            MessageBox.Show(string.Format(@"Calan kısının adı:{0},calan kısının soyadı:{1},Çaldıgı aletın markası:{2},Çaldıgı ses:{3}", mz.Ad, mz.Soyad, mz.caldıgıalet.Markasi, ses3));
        }
    }
}
