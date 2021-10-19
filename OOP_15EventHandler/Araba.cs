using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_15EventHandler
{
    public delegate void HızAsımıEventHandler();

    public class Araba
    {
        public Araba(int hiz, string model)
        {
            this.Hiz = hiz;
            this.Model = model;
        }

        //yeni bir olay ttanımlamak için event deyimi kullanılır olayları tetıklemek ıcın ısmı kullanılmalıdır.
        public event HızAsımıEventHandler HızAsımı;

        private int _hiz;

        public int Hiz
        {
            get
            {
                return _hiz;
            }
            set
            {
                _hiz = value;
                if (value>120)
                {
                    HızAsımı();
                }
            }



        }
        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }


    }
}
