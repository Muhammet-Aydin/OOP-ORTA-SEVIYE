using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ornek7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //
        public class BaseKitap
        {
            public DateTime CıkısTarihi { get; set; }
            public DateTime DüzenlenmeTarihi { get; set; }

            virtual public void GetLog()
            {
                //log ıslemlerı




            }

            public virtual void GetUser()
            {

                //user



            }
        }


        public class Kitap : BaseKitap
        {
            public int Id { get; set; }

            public string Adı { get; set; }

            public string Türü { get; set; }
            public string YazarAdi { get; set; }

            public string IsBnNo { get; set; }

            public override void GetLog()//base classsta vırtual olarak ısaretdıgı için bu metot burada overrıde edilebilir.
            {



            }


            public sealed override void GetUser()
            {





            }


        }
        public class CreateKitap : Kitap
        {
            //base classTA vırtual olarak belirlenen metot  derivved classta sealed yapıldı ondan derived alan classta override edilemez cunku muhurkendı.
           // override 
        


        }


    }

}
