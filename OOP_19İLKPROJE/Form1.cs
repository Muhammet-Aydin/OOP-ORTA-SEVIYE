using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_19İLKPROJE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        //personel ekleme metodu.
        Personel PersonelDoldur(Personel p)
        {
            p.Ad = txtad.Text;
            p.Soyad = txtsoyad.Text;
            p.TcNo = txttc.Text;
            p.Telefon = txttelefon.Text;
            p.IseGirişTarihi = dtişegiriş.Value;
            p.DogumTarihi = dtdogumtarihi.Value;
            p.Email = txtmail.Text;
            p.unvan = (Unvan)Enum.Parse(typeof(Unvan),cmbunvan.Text);//enum icinde unvanlarım var  parse edip typını verdkaktarılcak yer ve enuma cast etme işlemi yaptık.
            if (pictureBox1.Tag != null) 
            {

                p.PersonelResmi = Guid.NewGuid() +
                    pictureBox1.Tag.ToString();
                //bin//debug ieçrsine ımages ekleyecegız oradan alacagız

                pictureBox1.Image.Save(Application.StartupPath + "/Images/" + p.PersonelResmi);

            }

            return p;//personel istendiniginde new leyip gönderilecek. 
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            indexNo = listView1.SelectedItems[0].Index;//0 yazmamızın sebebi coklu seimde ilk ındex gelsın diye.
            listView1.Items.RemoveAt(indexNo);
            ExtentionMetot.Temizle(this.Controls);
        }

        //personeli listvieve doldurma metodu
        ListViewItem ListViewDoldur(Personel p)
        {
            //string[] personel = { p.Ad, p.Soyad, p.TcNo, p.IseGirişTarihi.ToString() };

            //ListViewItem lvi = new ListViewItem(personel);
            //lvi.Tag = p;


        ListViewItem lvi = new ListViewItem(p.TcNo);
            lvi.SubItems.Add(p.Ad);
            lvi.SubItems.Add(p.Soyad);
            lvi.SubItems.Add(p.IseGirişTarihi.ToString());
            lvi.SubItems.Add(p.Email);
            lvi.SubItems.Add(p.Telefon);
            lvi.Tag = p;//personeli tag olarak ustunde tutar.butun modelı ustune alır.
            return lvi;// personeli dondurur.
        }

        //enumları comboboxa doldurma işlemi
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbunvan.Items.AddRange(Enum.GetNames(typeof(Unvan)));//AddRange dizi kabul eder enumda bir dizi oldugu için ekleyebildik add deseydik ekleyemezdi. 
        }

        private void btnekle_Click(object sender, EventArgs e)
        { 
            Personel p = new Personel();
            p = PersonelDoldur(p);

            ListViewItem lvi = ListViewDoldur(p);
            listView1.Items.Add(lvi);
            ExtentionMetot.Temizle(this.Controls);
            //ExtentionMetot.Temizle(groupBox1.Controls); buda silme işlemi yapar.
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            guncelle = PersonelDoldur(guncelle);
            listView1.Items.RemoveAt(indexNo);
            listView1.Items.Insert(indexNo, ListViewDoldur(guncelle));
        }

            Personel guncelle;
            int indexNo;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            indexNo = listView1.SelectedItems[0].Index;
            guncelle = (Personel)listView1.SelectedItems[0].Tag;

            txtad.Text = guncelle.Ad;
            txtsoyad.Text = guncelle.Soyad;
            txttc.Text = guncelle.TcNo;
            txtmail.Text = guncelle.Email;
            txttelefon.Text = guncelle.Telefon;
            txtadres.Text = guncelle.Adres;
            dtişegiriş.Value = guncelle.IseGirişTarihi;
            dtdogumtarihi.Value = guncelle.DogumTarihi;
            cmbunvan.Text = guncelle.unvan.ToString();

            if (!string.IsNullOrWhiteSpace(guncelle.PersonelResmi))
            {
                pictureBox1.Image = Image.FromFile("Images/" + guncelle.PersonelResmi);
                pictureBox1.Tag = System.IO.Path.GetExtension(guncelle.PersonelResmi);

            }
        }
        private void btnresimseç_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//bastıgımızda resım seçme kısmı acılması ıcın yazdık.
            ofd.Filter = "Personel Resmi(jpg,gif,png)|*.png;*.jpg;*.gif";//filtreleme yaptık bu formatta olan resımler cıksın dıye.
            DialogResult dr = ofd.ShowDialog();//open file diplog içinden baselerden birinden gelir.
            if (dr==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.Tag = Path.GetExtension(ofd.FileName);
            }
        }
    }

}
    
