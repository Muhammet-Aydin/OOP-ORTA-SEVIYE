using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_16IComparable
{
    class Takım : IComparable<Takım>
    {
        //Eğer oluşturmuş olduğunuz class tipindeki değerleri içerisinde yer alan bir liste tanımladıysanız ve bu listeyi sort metodu yardımıyla sıralamaya çalışırsanız sistem hata verir.hata;liste içerisinde en az bir tip ile mutlaka IComparable imlemente etmen gerektiğini söyler.
        //Bunun sebebi sistemde tanımlı olmayan bir tipin hangi özelliğini karşılaştırılacağının bilinmemesidir.

   

        public string Adi { get; set; }
        public byte puani { get; set; }
        public sbyte Averaji { get; set; }



        public int CompareTo(Takım other)
        {
            if (this.puani < other.puani)
            {
                return 1;
            }
            else if (this.puani > other.puani)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }



        public override string ToString()
        {
            return this.Adi;
        }
    }
    //Classın farklı özelliklere göre sıralanmasını istersenız yapmanız gereken şey ise bir kıyaslayıcı sınıf(IComparer interfacesinin imlemente edilmesi.)bu şekilde yapmalıyız...
    class PuanıKüçüktenBüyüğeSırala : IComparer<Takım>
    {
        public int Compare(Takım x, Takım y)
        {
            return -(x.CompareTo(y));
        }
        
    }
    class AverajaGöreBüyüktenKüçüğeSıralama : IComparer<Takım>
    {

        public int Compare(Takım x, Takım y)
        {
            return x.Averaji.CompareTo(y.Averaji);
        }
        //AverajaGöreküçüktenBüyüğeSıralama avg1 = new AverajaGöreküçüktenBüyüğeSıralama();

        //public int Compare(Takım x, Takım y)
        //{
        //    return (avg1.Compare(x, y));
        //}
        //public int Compare(Takım x, Takım y)
        //{
        //    if (x.Averaji > y.Averaji)
        //    {
        //        return 1;
        //    }
        //    else if (x.Averaji < y.Averaji)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}
    }
    class AverajaGöreküçüktenBüyüğeSıralama : IComparer<Takım>
    {
        AverajaGöreBüyüktenKüçüğeSıralama avg = new AverajaGöreBüyüktenKüçüğeSıralama();
        public int Compare(Takım x, Takım y)
        {
            return -(avg.Compare(x, y));
        }
        //AverajaGöreküçüktenBüyüğeSıralama avg = new AverajaGöreküçüktenBüyüğeSıralama();

        //public int Compare(Takım x, Takım y)
        //{
        //    return -(avg.Compare(x, y));
        //}
    }
    
   
    class AdaGöreBüyüktenKüçüğesıralama : IComparer<Takım>
    {
        public int Compare(Takım x, Takım y)
        {
            return x.Adi.CompareTo(y.Adi);
        }
    }
    class AdaGöreKüçüktenBüyüğesıralama : IComparer<Takım>
    {
        AdaGöreBüyüktenKüçüğesıralama adg = new AdaGöreBüyüktenKüçüğesıralama();



        public int Compare(Takım x, Takım y)
        {
            return -(adg.Compare(x, y));
        }
    }
}

