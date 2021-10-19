using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_13.INTERFACE_YAPISI
{
    public interface IFutbolcu
    {
         string AdSoyad { get; set; }
         string FormaNumarasi { get; set; }
         byte SutGucu { get; set; }
        byte Reflex { get; set; }

        byte Agresiflik { get; set; }
        bool Millimi { get; set; }

        void SutCek();
        void TopKurtar();



    }
}
