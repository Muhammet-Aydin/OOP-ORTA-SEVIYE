using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KALITIM_FORM_UYGULAMA
{

    //BasePhone en ust class mobile ondan turer mobıledende smartphone turuyor.
    public class BasePhone
    {
        private string _brand;//fıeld leri tanımladık. 
        protected string _phonetype;
        protected string _connectiontype;

        public BasePhone()//constructor metot
        {

            _phonetype = "ahizeli Telefon";//parametresız olursa   phone tipi deger verilmiş gelir.
        }
        public BasePhone(string brand, string connectionType)//2parametlei ctor tanımlarsak bunlar gelir.
        {
            _brand = brand;
            _connectiontype = connectionType;
            _phonetype = "ahizeli Telefon";

        }

        public string Brand
        {
            get
            {
                return this._brand;
            }
            set
            {
                this._brand = value;
            }
        }
        public string PhoneType
        {
            get
            {
                return this._phonetype;
            }
            //set
            //{
            //    this._phonetype = value;
            //}
        }
        protected string ConnectionType
        {
            get
            {
                return this._connectiontype;
            }
            set
            {
                this._connectiontype = value;
            }
        }

        public virtual string Call()//smartphne ve mobıle phone da arama işi vardır fakat biçimi farklıdır.bu işleme cok bııcımlılık uygulanmıs olur.
        {
            return "aradım.";
        }
        public virtual string ConnectionStatus()
        {

            return "Kablulu Baglantı";

        }



    }
}
