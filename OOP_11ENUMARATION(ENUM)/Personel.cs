using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_11ENUMARATION_ENUM_
{
    public enum Departmanlar
    {
            yazılım,
            sistem,
            aguzmanlıgı,
            grafıktasarım,
            ingilizce,
            muhasebe,
            
    }

    class Personel
    {

        private string AdiSoyadi;//field

        public string adisoyadi//prop
        {
            get { return AdiSoyadi; }
            set { AdiSoyadi = value; }
        }

        private Departmanlar _departmanlar;

        public Departmanlar departmanlar
        {
            get { return _departmanlar; }
            set { _departmanlar = value; }
        }









    }
}
