using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_17INumarable
{
    //class ıcerısınde herbır elemanın tek tek ele alınabilmesini istiyorsanız. o classınızı "INumarable ınterfacesine" implemet edceksınız.
    public class Takım:IEnumerable
    {
        public Takım(params Futbolcu[] futbolcular)
        {
            this.TakımOyunculari = futbolcular;
        }

        private Futbolcu[] TakımOyunculari { get; set; }//takım oyunlclarının degerlini tutmak ıcın dızı tanımladık.



        public int FutbolcuAdet
        {
            get
            { return this.TakımOyunculari.Length; }//dizinn uzunlugu oyuncu adetını verir.
        }
        public double FormaNumaraOrtlamasi
        {
            get
            {

                double ortalama = 0;
                IEnumerator sayac = TakımOyunculari.GetEnumerator();
                while (sayac.MoveNext())
                {
                    ortalama += ((Futbolcu)sayac.Current).FormaNumrasi;

                }
                return ortalama / FutbolcuAdet;
            }
        }
        public IEnumerator GetEnumerator()
        {

            return new FutbolcuEnumarator(TakımOyunculari);


        }       
    }
    class FutbolcuEnumarator : IEnumerator
    {//1dizi uzerınde donulecegı için degişken olusturuaım
        private Futbolcu[] DönecegimDizi;

        //2 donmeye kacıncı ındexten baslayacak
        // id degerin -1 olmasının sebebi forerch calısmaya move -next metotdundan baskaması rensbıbır.
        //move next metodu içersinde oncelıkle sırada elean varmı dıye  bakar  var se curreent properyy sı harekete gecer.


        int index = -1;
        //e numarator classı ıcerısındekı "dönecegim dşzş adlıdızının aslı degildir
        //sorusuna cevap verebilek için bu classın ctorı paramterlı hae getirdim."

        public FutbolcuEnumarator(Futbolcu[] hangidizidönmeliyim)
        {
            this.DönecegimDizi = hangidizidönmeliyim;
        }


        public object Current
        {
            get
            {
                return DönecegimDizi[index];
            }
        }
        //movenext  moetudu sırada bşr eleman varmı yokmundıye kontrol eder varsa tura dönder dongu devam eder flase donerse dongu snlanır.
        public bool MoveNext()
        {
            index++;
            return this.index<DönecegimDizi.Length;
        }

        //dongunuun buttugu anda devreye gier turnkeyı sıfırlar.
        public void Reset()
        {
            int index = -1;
        }
    }
}
