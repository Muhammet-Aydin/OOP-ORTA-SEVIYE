using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOP_18SpecialCollectıons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        //asagıda  ozel olarak bakacagımız kolleksıyon tıplere baktıgımızda sunları görecegız
        //.net kutuphanesı içerisinde onceden tanımlı bir cok koleksıyon tipi bulunmaktadır.
        //ancak asagı yazacagımız tum kollecsıyonlrın ortak noktalarından olan bır durum performsnlı degildirdirler.

        private void btnhashtable_Click(object sender, EventArgs e)
        {
            //system.collection.hashtable
            //anahtar deger ıkılı mantıgı ıle key value pair calısan ozel bır kollecsıyon tipidir.hashtabl veri olarak anahatar ve deger kısmında "object" tipinde veri alır.
            //genekklıkle buyuk boyutlu kollesıyonlar için (örnek:nortwind veri tabanındakı orders veri tablsunu alabiliriz.) 
            //hashtable ıcerısındekı dergerleri ramdakı referans degerlerne göre sıralayacaktır.
            //hashtable dekı key mantıgı gercek brir key mantıgı oldugu ıcın unıqe olma zorunlulugu varıdr.
            //ve kullanılan degeri asla bir daha kullanamazsın.
            //bir hashtable olustabilmek için 
            //10dan az ıse normal fazla ise tersten sıralar.

            Hashtable anahtardegerikilisi = new Hashtable();
            anahtardegerikilisi.Add("isim","YLZ3150");
            anahtardegerikilisi.Add("Sayi", 15);
            anahtardegerikilisi.Add("FORM", new Form {Width=300,Height=300 });


            ((Form)anahtardegerikilisi["FORM"]).Show();//DEGERİ  ALMAK İÇİN DİZİ OLARAK GİRMEK YANI KOSELİ PARANTEZ ICINE YAZMAK GEREKİYOR. OBJECT DONDUGU ICIN CAST ISLEMI GERKEİR.

            anahtardegerikilisi.Add(7, "JAMES BOND");
            anahtardegerikilisi.Add(10,"MESSİ");
            anahtardegerikilisi.Add(23,"DAVİD");
            anahtardegerikilisi.Add(55,"SABRİ");
            //HASHTABLE İÇERİSİNDEKİ BİR VALUE YU CEKEMEK ÇİN YAPMANIZ GEREKEN KOSELI PARANTEZ İÇERİSİNDEKİ O DEGERİ TASIYAN ANAHATARI VERMEK OLACAKTIR.
            //MessageBox.Show(anahtardegerikilisi[55].ToString());
            anahtardegerikilisi.Remove(55);//silmek için 
            //MessageBox.Show(anahtardegerikilisi[55].ToString());

            if (anahtardegerikilisi.ContainsKey(15)) 
            {
                MessageBox.Show("zaten var");
            }
            else
            {
                anahtardegerikilisi.Add(15, "milan baros");
            }

            bool deger = anahtardegerikilisi.ContainsValue("DAVİD");
            

            foreach (var item in anahtardegerikilisi.Keys)
            {
                listBox1.Items.Add(string.Format("anahtar :{0}-deger:{1}",item,anahtardegerikilisi[item]));
            }
        }

        private void btnlistdictianory_Click(object sender, EventArgs e)
        {
            // System.Collection.Specialiezed
            //hashtabledan daha az gelişmiş bir ozel koleksıyon tipidir.
            //tipkı hashtalbe gibi key value pair mantıgı ile calısan bir yapıdır.
            //daha az gelişmiş yapdıır ornek olarak contaınsvalue  yapısı içinde yoktur.


            ListDictionary anahtardegerdizisi2= new ListDictionary();

            anahtardegerdizisi2.Add(1, "JAMES BOND");
            anahtardegerdizisi2.Add(2, "MESSİ");
            anahtardegerdizisi2.Add(3, "DAVİD");
            anahtardegerdizisi2.Add(4, "SABRİ");
            anahtardegerdizisi2.Add(5, "YLZ3150");
            anahtardegerdizisi2.Add(6, "ANKARA");
            anahtardegerdizisi2.Add(7, "ADIYAMAN");


            foreach (var item in anahtardegerdizisi2.Keys)
            {
                listBox1.Items.Add(string.Format("anahtar :{0}-deger:{1}", item, anahtardegerdizisi2[item]));
            }


        }

        private void btnHybrd_Click(object sender, EventArgs e)
        {

            //hashtable ve listdıctıanory mantıgı ile calısır.
            //msdn ın soylemnıe göre eger koleksyınonuz kucuukse (10 ve altı eleman sayısı) listdictionary olarak davranır.10un uzerındeyse hashtable oalrakk davranır.
            //yapacagınız koleksıyon secimi performansa yansır.

            //10 elemandan fazla eleman varsa tersten sıralama ıslemı yapar.azsa normal calısır.

            HybridDictionary anahtardegerdizisi3 = new HybridDictionary();
            anahtardegerdizisi3.Add(1, "JAMES BOND");
            anahtardegerdizisi3.Add(2, "MESSİ");
            anahtardegerdizisi3.Add(3, "DAVİD");
            anahtardegerdizisi3.Add(4, "SABRİ");
            anahtardegerdizisi3.Add(5, "YLZ3150");
            anahtardegerdizisi3.Add(6, "ANKARA");
            anahtardegerdizisi3.Add(7, "ADIYAMAN");

            foreach (var item in anahtardegerdizisi3.Keys)
            {
                listBox1.Items.Add(string.Format("anahtar :{0}-deger:{1}", item, anahtardegerdizisi3[item]));
            }



        }
    }
}
