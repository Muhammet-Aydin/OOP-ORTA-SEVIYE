using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_17INumarable
{
    public class Futbolcu
    {
        public enum Mevkiler
        {
            Kaleci, Defans, OrtaSaha, Forvet

        }

        public string AdSoyad { get; set; }
        public byte FormaNumrasi { get; set; }
        public Mevkiler mevkiler { get; set; }

        public override string ToString()
        {
            return string.Format("{0}({1 })-{2}", this.AdSoyad, this.FormaNumrasi, this.mevkiler);
        }



    }

}
