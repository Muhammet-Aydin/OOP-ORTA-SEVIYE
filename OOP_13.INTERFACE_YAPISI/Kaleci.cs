using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_13.INTERFACE_YAPISI
{
    public class Kaleci : IFutbolcu
    {
        public string AdSoyad { get ; set; }
        public string FormaNumarasi { get; set; }


        private byte _SutGucu;
        public byte SutGucu       
        { 
            get
            {
                return _SutGucu;
            }
            set
            {
                if (value<70)
                {
                 System.Windows.Forms.MessageBox.Show("sut gucu 70den az olamaz.");
                }
                else
                {
                    _SutGucu = value;
                }
            }
        }

        public byte Reflex { get; set; }
        public byte Agresiflik { get; set; }
        public bool Millimi { get ; set ; }

        public void SutCek()
        {
            System.Windows.Forms.MessageBox.Show("Güzel sut çekemem");
        }

        public void TopKurtar()
        {
            System.Windows.Forms.MessageBox.Show("Benim işim top kurtarmak.");
        }

        public override string ToString()
        {
            return AdSoyad;
        }
    }
}
