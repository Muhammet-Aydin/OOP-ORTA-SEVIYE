using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_15EventHandler
{
    public partial class Form1 : Form
    {
        //events(olaylar):kulanıcının fareyle tıklaması klavyeden tusa basması gibi işetim sistemi uzerınde gercekeletırdıgı eylemlere event denir.bir bilesen uzerınden ekrana gelen olayları takıp eden ve bunların yakalayan mekanızmadır.
        //event handler:ilgili olay gerçeklestıgı zaman tetıklenır olay gerçeklestıkten sonra hangı işlemelrin yapılacagı olay yonetıcılerı için dilerseniz  delegerler ile temsıl edilir.bşr kullanıcının fare ıle tıklama olayı click olayıdır.yada bir tusa basması bir keypress olayıdır.bu işlemler sonucunda nelerın yapılamsı gerektıgıni biz kodlarız.
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araba rb = new Araba(70, "bmw");
            rb.HızAsımı += new HızAsımıEventHandler(HızAsımı);
            //tıpkı bir olayı bir metoda balamak ıcın += kullanıldıgı gibicıkarmak içinde -= kullanılmalıdırdır.

            //olayların baglanacagı metotların ımza yapıları olayların turu olan delege ımzası ıle ayı olmalıdır.
            //buradan soyle dusunun bir eventten onec mutlaka delege ıle tanımalnmaldır.event oncesınde acces modıfıer tanımlanmalıdır.
            //statıc vırtual override

            for (int i = 0; i < 7; i++)
            {
                rb.Hiz += 10;
                listBox1.Items.Add("arabanın suankı hızı " + rb.Hiz);
            }
        }

        private void HızAsımı()
        {
            MessageBox.Show("arac Limiti astı");
        }
    }
}
