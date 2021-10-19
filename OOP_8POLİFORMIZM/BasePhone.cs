using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8POLİFORMIZM
{
    public class BasePhone
    {
        public int İd { get; set; }

        public string Brand { get; set; }

        public decimal UnitPrice { get; set; }

        public virtual void CallSound()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\SesDosyasi\cellph.wav"))//nesne isini hallettıkten sonra ucuruyor.bidaha kullnaılmamasını ıstıyorsanız usıng ıcıdne yapın.usıng içerisinde kullanılan nesne gc tarafından temızlenmeesı beklenmz dırek sılınır.envıronmen.current drectroy bin debug ana dızınını baz alır.
            {
                player.PlaySync();
            }



        }




    }
}
