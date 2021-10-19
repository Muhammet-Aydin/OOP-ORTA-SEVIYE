using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_11ENUMARATION_ENUM_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        //Enum 
        //kisilere sabit secenekler sunmak için kullanılan bir deger tiplidir.
        //seceneklerı kontrol altında tutup uygulanamanızı kendı kontrolumuz cevresinde yonetmenzi olanak saglar.
        //guvenilir ve performanslıdırlar.
        //enumlarda yazılı degerini teslım almak istersek getname metotdu kullanılır.
        //yazılı hale getitrilmiş olan bşr enum degerını tekrardane enum seklıne dondurmek için enum.parse metodu ile dondururlur.
        //bşr enum arkaplanda sayısal deger tutar.bu degeler varsayılan olarak secılen ındex degelreiridir. bu degelrın tipi int  olarak tutulur.seizin kullanacagınız enum sayısı daha az ıse byte vb olarakta tutulaabilir.istediginiz degerdende baslatabilirsiniz.
        //enum.parse işlemi size object tipinde donecektır.donen deger sonucunde siz unboxıng castıng  işlemi yapmanız degekir.



        private void button1_Click(object sender, EventArgs e)
        {
            //Personel p = new Personel();
            //p.adisoyadi = "muhammet aydın";
            //p.departmanlar = Departmanlar.yazılım;


            
            Personel prs = new Personel();
            prs.adisoyadi = txtPersonelAdi.Text;
            prs.departmanlar = (Departmanlar)Enum.Parse(typeof(Departmanlar), cmbpersoneldepartman.Text);

            int secilienumındexi = (int)Enum.Parse(typeof(Departmanlar), cmbpersoneldepartman.Text);

            Departmanlar cıkacakdeger;

            bool sonuc = Enum.TryParse<Departmanlar>(cmbpersoneldepartman.Text, out cıkacakdeger);

            if (sonuc)
            {
                MessageBox.Show("personel deppartmanı=>>"+cıkacakdeger);
            }
            else
            {
                MessageBox.Show("uygun departman secildiiginden emin olunuz.");
            }
            switch (prs.departmanlar)
            {
                case Departmanlar.yazılım:
                    MessageBox.Show("yazılım");
                    break;
                case Departmanlar.sistem:
                    MessageBox.Show("sistem");
                    break;
                case Departmanlar.aguzmanlıgı:
                    break;
                case Departmanlar.grafıktasarım:
                    break;
                case Departmanlar.ingilizce:
                    break;
                case Departmanlar.muhasebe:
                    break;
                default:
                    break;
            }
        }

    private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetNames(typeof(Departmanlar)))
            {
                cmbpersoneldepartman.Items.Add(item);
            }
        }

    private void cmbpersoneldepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbpersoneldepartman.Items.AddRange(Enum.GetNames(typeof(Departmanlar)));
            //cmbpersoneldepartman.SelectedIndex = 0;
        }
    }
}

