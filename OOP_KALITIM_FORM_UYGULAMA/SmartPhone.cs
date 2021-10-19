using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KALITIM_FORM_UYGULAMA
{
    public class SmartPhone : MobilePhone
    {
        public bool FrontCam { get; set; }

        //videolu arama baslatıldı.metto yaz.

        public SmartPhone()
        {
            HasCamera = true;
            _phonetype = "";
        }
        public SmartPhone(bool frontcam, bool hascamera, bool ıstouched, string brand, string connectiontype) :
                          base(hascamera, ıstouched, brand, connectiontype)
        {
            //1tane kendı ozellıgı var 4 tanede ust classtan mıras aldı toplam 5 tane paramtre alması gerekıyor.
            base._phonetype = "Smart Phone";
            this.FrontCam = frontcam;
            //base.HasCamera = hascamera;
            //base.IsTouched = IsTouched;
            //base.Brand = brand;
            //base.ConnectionType = connectiontype;


        }










    }


}
