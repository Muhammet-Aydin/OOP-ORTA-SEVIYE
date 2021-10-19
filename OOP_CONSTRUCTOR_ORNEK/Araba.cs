using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CONSTRUCTOR_ORNEK
{

    //const:propşara bus seiklde daha oncede deger vermeyı ogrenmıstık.sımdı araba classını olusturduk ctor dıyerek sonctructorunu olusturduk ctor parametre içinde bulundugu sınıfın hangı  prplerıne deger atamak istiyorsak o sekılde yazılırlar ve varsayılan olarak sınıfımıza tum proplara yapıcı metot uzerınden ulasırız.
    class Araba
    {
        public string marka { get; set; }
        public string model { get; set; }
        public float motorgücü { get; set; }

        public Araba(string _marka,string _model,float _motorgücü)
        {
            marka = _marka;
            model = _model;
            motorgücü = _motorgücü;
                
        }
    }
}
