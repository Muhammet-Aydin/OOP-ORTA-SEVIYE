using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_19İLKPROJE
{
    public class Personel
    {
        public int Id  { get; set; }

        public string TcNo { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        public string Telefon { get; set; }

        public string Email { get; set; }
        public string Adres { get; set; }

        public DateTime IseGirişTarihi { get; set; }

        public Unvan unvan { get; set; }

        public string PersonelResmi { get; set; }

        public object Tag { get; set; }


    }
}
