using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_RevVeValueType_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std._FirstName = "ahmet";
            std._LastName = "tas";


            Student std2 = std;
            std2._FirstName = "mahmut";

            MessageBox.Show(std.GetHashCode() + "\n" + std2.GetHashCode());//2sıde farklı alanlar acıtıgı için kodları farklıdır.

            MessageBox.Show(std2._FirstName);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ögrenci ögr = new Ögrenci();
            ögr._Adi = "ali";
            Ögrenci ögr2 = new Ögrenci();
            ögr2._Adi = "muhammet";
           ögr2 = ögr;

            MessageBox.Show(ögr.GetHashCode()+"\n"+ögr2.GetHashCode());//referans tiplerin gethaskodu aynıdır.referansta aynı yere baktıkları için aynı hash kodu aynı gelir.

            MessageBox.Show(ögr2._Adi);

            int[] sayılar = { 5, 62, 89, 52 };
            int[] sayılar2 = sayılar;

            sayılar[1] = 10;

            MessageBox.Show(sayılar[1].ToString());


        }
        //.nette mantık gereği uygulama uzerınden geçici olarak kullanılan tum nesnelere ram uzerınde kendılerınje bir yer ednilrler ramın teknık kısmına baktıgımızda 2 farklı bolgede tutuldugunu görürsünüz.bunlardan biri stack heap, stack bölümünde value type dedigğimiz tipler tutulur(enum,int,bool,double,byte,struct) heap alanında degeri tutulanlar(class,delegate,arrayler,string,) value typeların degeri copyalanabilme ozellıgıne sahipken referans tiplerde bu iş tasıma olarak algılanabilir.
        //bir degerin null olması o degerin karsılıgının olmaması demektir
        //referans tiplerde heap alanının null yapmaya calısırsan yapabilirsin ama deger tiplerde null geçemezsın. deger tiplerde null geçemezsin.
        //value type amacı:value tiplerdeki bir nesneyi tum verisini kendı ıcerisinde tutar
        //referasn typelara datayı tutmaz onun yerıne adresını gösterir.yanı referansını tutar.
    }
    class Ögrenci
    {
        private string Adi;

        public string _Adi
        {
            get { return Adi; }
            set { Adi = value; }
        }


        private string Soyadi;

        public string _Soyadi
        {
            get { return Soyadi; }
            set { Soyadi = value; }
        }


        

    }
    struct Student
    {
        //struct yapısı en bastı tanımlıyla classların deger tipi versiyonudur.

        //struct ıle class arasındakı en buyuk farklardan bir tanesi struct lar baska bir structtan yada classtan kalıtım almazlar ama interface implemente edebilirler.

        //eger struct ile class arasında kalırsan nesneın boyutuna göre tercih yap.16kb dusukse struct yapısını kulln.
        private string FirstName;

        public string _FirstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        private string LastName;

        public string _LastName
        {
            get { return LastName; }
            set { LastName = value; }
        }


    }

   



}
