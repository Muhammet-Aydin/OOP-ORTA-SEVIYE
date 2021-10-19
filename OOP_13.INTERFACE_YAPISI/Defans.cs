using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_13.INTERFACE_YAPISI
{
    public class Defans : IFutbolcu
    {
        public string AdSoyad { get ; set; }
        public string FormaNumarasi { get ;set ; }
        public byte SutGucu { get; set; }
        public byte Reflex { get; set; }
        public byte Agresiflik { get; set ; }
        public bool Millimi { get; set; }
       

        public void SutCek()
        {
          
        }

        public void TopKurtar()
        {
            
        }
        public override string ToString()
        {
            return AdSoyad;
        }





    }
}
