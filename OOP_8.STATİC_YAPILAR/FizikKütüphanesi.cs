using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_8.STATİC_YAPILAR
{

    //statıc class
    //eger nesneye baglı işlemler gerceklestırıyorsanz /yanı  amac sadece belirli bir durumda hizmet eden ögleri bir araya toplamak için statıc classlar kullanılır.
    //içerisindeki tum ögleri instance dan bagımsız olarak erişilebilir.
    //statıc sınıfar ıcerısınde yalnızca statıc ornekler barınır field prop metot
    //statıc classlarda baska bşr classtan kaltıım almaz ancak objetten alırlar bu dahil degildir.
    //ornek math ve file sınıfdır.
    //math sınıfı matematıksel ıslemlerı bir arada tutar.
    //file dosya bazlı ılemlerı bir arada tutar.
    //statıc classlar newlenemezler.
    //hızlıca erısılıp kullanmayı saglar
    //hers sınıf statıc olarak ısaretlenmemelıdır.
    //cunku her işaretleme performans kaybına neden olur.


    public static class FizikKütüphanesi
    {

        public static Decimal YerÇekimiKuvveti { get { return 9.8M; } }
        //const sabit degerler için kullanılırlar.kendılıgınden statıc olma ozelliğine saiptirler.
        public const int KaldırmaKuvveti = 50;

        //readonly>>sadece okunabilir degişkenler olusturabilmek için kullanılan anahtar kelımedir.

        public static readonly int Kuvvet = 70;

        public static void Kaldır()
        {




        }


    }
}
