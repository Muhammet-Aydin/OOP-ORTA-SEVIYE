using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8POLİFORMIZM
{
    public class Nokıa:BasePhone
    {
        public override void CallSound()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\SesDosyasi\ring.wav"))
            {
                player.PlaySync();
                
            }
        }








    }
}
