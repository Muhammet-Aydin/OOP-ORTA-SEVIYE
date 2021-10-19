using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_17INumarable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngtr_Click(object sender, EventArgs e)
        {
            Futbolcu f1 = new Futbolcu { AdSoyad = "muslera", FormaNumrasi = 5, mevkiler = Futbolcu.Mevkiler.Kaleci };



            Futbolcu f2 = new Futbolcu
            {
                AdSoyad = "kenan karaman",
                FormaNumrasi = 33,
                mevkiler = Futbolcu.Mevkiler.Forvet
            };

            Futbolcu f3 = new Futbolcu()
            {
                AdSoyad = "alı yılmaz",
                FormaNumrasi = 30,
                mevkiler = Futbolcu.Mevkiler.OrtaSaha




            };

            Takım takim = new Takım(f1,f2,f3);
            //foreach (var item in takim)
            //{
            //    listBox1.Items.Add(item.ToString());
            //}
            IEnumerator sayac = takim.GetEnumerator();

            while (sayac.MoveNext())
            
            {
                listBox1.Items.Add(sayac.Current);
            }
            MessageBox.Show("bu takımda toplam "+ takim.FutbolcuAdet+"oyuncu vardır.");
            MessageBox.Show("takım oyuncularının forma numarsı ortlaması==>"+takim.FormaNumaraOrtlamasi);




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
