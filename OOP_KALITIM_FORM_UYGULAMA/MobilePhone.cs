using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KALITIM_FORM_UYGULAMA
{
    public class MobilePhone:BasePhone
    {

        public bool HasCamera { get; set; }
        public bool IsTouched { get; set; }

        public MobilePhone()
        {
            _phonetype = "Mobile telefon";
        }
        public MobilePhone(bool hascamera,bool ıstouched,string brand,string connectiontype):base(brand,connectiontype)
        {
            this.HasCamera = hascamera;
            this.IsTouched = ıstouched;

            _phonetype = "Mobile Phone";

            base.Brand = brand;
            base.ConnectionType = connectiontype;
            //bu sekıldede olur  yukarıdakı base parametresını silerekte yapılabilir. 

            //:base() >> miras aldıgı sınıf içerisinde ctor var ıse bu sekılde mıras alınan sınıf ıcerısındekı ctora atama yapabilirsiniz.
            //ctor yerine icerdede atama yapabilrsniz
            //this.brand=brand;
            //base.connectiontype=connectiontype;
        }
        public string TakePhoto()
        {
            if (HasCamera)//==true demekle aynı aynalama gelir true yazmıs gibi
            {
                return "resim çekebilirim.";
            }
            else
            {
                return "resim cekemem.";
            }
        }
        public override string ConnectionStatus()
        {
            return base.ConnectionStatus();//base deki connecutıon status metotdu caslıstırır ordan return edileni çagırır.overrride gibi cagırır fakat ıerigi degişmez. hıc yazmazsakta baseddekı gibi calsırı.eger hic ezmeden kullanmak ıstıyorsak kullanmsssak mobile newledigimizde yine gelir bu sefer baseclasstan gelir.
            
        }

    }
}
