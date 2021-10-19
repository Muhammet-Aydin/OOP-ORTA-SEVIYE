using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_5Struct_Sealed_Yapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

           Kitap kt;

        private void Form1_Load(object sender, EventArgs e)
        {

            kt.Adi = "suz ve ceza";
            kt.Id = 1;
            kt.IsbnNo = "1123";
            kt.Türü = "korku";
            kt.YazarAdı = "dostayeeskı";
            kt.degeri = 50;

            
            


            //STRUCT YAPISI GEREİ DEGER TIPLI OLDUGUDAN RAM UZERIDNE STACK ALANINDA tutulmaktadaır.
            //her ne kadar classa benzessede ozellikle detayını ıncelediginizde bazı ozellıklerıyle ayrılmaktadır.
            //1)STRUCT YAPIDA PARAMETRESIZ CONSTRUCTOR TANIMLANMAZ
            //2)EGER TANIMLAYACAKSANIZ MUTLAKA PARAMETRE ISER
            //3)PARAMETRELI TANIMLANAN YAPICI METOT TANIMLADIGINIZDAN DOLAYI BASLANGIC DEGERÖERN ATAMAK ZORUNDASINIZ
            //4)STRUCT YAPILARINDA BOS YAPICI METOT TANIMLANAMADIGINDAN DOLAYI NEW ANAHTAR KELIMESI NEDEN KULLANILIYOR DOYE BIRSEY YOK EGER CLASS YAPILARINDA OLUSTURURSANIZ VOİD CTOR TETIKLENIP CALISIRDI AMA BUARADA YOK DIKKAT.
            ////eger yapı olarak bıraz daha detayına bakacak olursak new object olarak tanımlanmısıtr
            /////struct =>>>initobj yapısı calısmaktadır.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Kitap kt1 = new Kitap(1, "abc", "asfgf", "3245", "adsgfht", 15);
            List<Kitap> kitaps = new List<Kitap>();
            kitaps.Add(kt);
            kitaps.Add(kt1);
            foreach (var item in kitaps)
            {
                listBox1.Items.Add(item.Adi+item.IsbnNo+item.Türü+item.YazarAdı+item.Id+item.degeri);
            }
        }
    }

    public   struct Kitap
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Türü { get; set; }
        public string IsbnNo { get; set; }
        public string YazarAdı { get; set; }

        public int degeri;

        public Kitap(int _ıd, string _adi, string _türü, string _ısbnNo, string _yazarAdı,int _degeri)
        {
            Id = _ıd;
            Adi = _adi;
            Türü = _türü;
            IsbnNo = _ısbnNo;
            YazarAdı = _yazarAdı;
            degeri = _degeri;
        }
       

    }
}
