using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_8.STATİC_YAPILAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text=FizikKütüphanesi.YerÇekimiKuvveti.ToString();
            // FizikKütüphanesi.YerÇekimiKuvveti = 40; deger atamayız cunku set işlemi kapalı yanı readonly yapılmıstır.
            string isim = "iüöğı";
            string yeniisim=isim.ClearSesli();
            int a = FizikKütüphanesi.Kuvvet;
            label1.Text = a.ToString();
            this.Text = yeniisim;
        }
    }
}
