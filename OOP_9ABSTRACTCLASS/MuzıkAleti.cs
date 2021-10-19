using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_9ABSTRACTCLASS
{
    /// <summary>
    /// Abstract classlar sadece base class gibi davnranmasını (yani kaltıım edilebilmesi) ve kendınden ınstance cıkarılması gerektııgı durumlarda kullanılır.
    /// </summary>
    public abstract class MuzıkAleti
    {
        //abstract olarak ısaretlnemiş tum yapıları mutlaka overrıde edilmek zorundadır 
        //abstract classların en buyuk ozellıuıgı  içerisinde absttract olan yada  olmayan metotları barındırabilmektedir.
        //absract metotları kaltıım aldıgı classta ımplemente edilerel kullanılacak metotlardır yanı tanımalndıgı yerde herhango bir kod blogu bulundurmazlar yapının ıcınde herhangı bşr metot tanımlarsanız bu metot sadece ımzasıyla bu absttract classın ıcerısınde bulunur.
        //abstract dedıgımız bşr ısaretleyıcıdır.sealed gibi sınfı soyut hale getirir.
        public string Markasi { get; set; }

        public  string Aciklamasi { get; set; }

        //abstract mettot yazdık. diger sınıflarda cagırrken overrıde edip tanımalrız.
        //abstract class metotları tanımlarken asagıdakılere dıkkat edişmesi gerekir.
        //1-)abstract metotlar private olarak tanımalanamazlar.mıras alınan classlar tarafından ımlemente edilemedıkten dolayıabstract yapısına ters dusmektedir.
        //2-)abstract mettotdu abstrract olan classın altına tanımlanır.
        //3-)abstract metottlar virtual olarak tanımlanamazlar.herbir abstract class virtual dur.
        //abstruct classın  amacı mıras aldıgı classta ımpolemente edilmek oldugu için zaten mantıkejn vırtual yazdgınızda hata vericektir.
        //4-)abstact metotlar asla statıc olarak tanımlanamazlar.statıc kavramı class ozellıgı yada metot oldugu için ınstance cıkarmaya gerek yoktur.halbukı statıc olmayan myapılar ınstance uretılebilen yapılardır.
        //public static string acıklama { get; set; }
        //5-)abstrac bir classra abstract oolmayan statıc bir metot tanımlayabiliyorken mıras aldıgı classta ımplemente eıdlme zrounlulugundan dolayı abstact metotlar stacı olarak tanımlanamazlar.
        //7-)abstact metotlarn gövdelerı yoktur.
        //cunku onlar sadece mıras alındıgı sınıfta ımplementte ediilebilir.
        //8-)abstact sınıflar newlenemezler
        // MuzıkAleti mzk = new MuzıkAleti();


        public abstract string Cal();
        






        




    }
}
