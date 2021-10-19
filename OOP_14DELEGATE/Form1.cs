using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_14DELEGATE
{
    public partial class Form1 : Form
    {
        public delegate void Logger(string message);//logger metotlarını temsılen bir temsilci yazdık.bu bir classtır ama delegate ıslemı yapar.

        public void Smslogger(string message)
        {
            lbl_sms.Text = message;
        }
        public void MailLogger(string message)
        {
            lbl_mail.Text = message;   
        }
        public void XmlLogger(string messsage)
        {
            lbl_xml.Text = messsage;
        }
        public void DbLogger(string message)
        {
            lbl_db.Text = message;
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            Logger logger = new Logger(Smslogger);
            logger += DbLogger;
            logger += XmlLogger;
            logger += MailLogger;

            logger.Invoke("hello world");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //delegate 
        //bir olay gerçeklestıgınde birden fazla fonksıyonun cagırmak istediginizi hayal
        //ornegın :kullanıcı bir butona tıkladıgında birden fazla metot otomatık olarak cagırılmasını ıstıyorsunuz bunun için delegate kullanabilirsiniz burada amac sudur.
        //bir olay oldugunda birden fazla yere bu olayı bıldırmektır.bu olay ıle ilgilnen delegate ile olaydan haberleri olur.
        //yada
        //temsilci olarak adlandırabilecegımız bu yapı asıl ayakta tutan nesnelerın yormak yerıne onların ısleerını uzerıne alarak gerçeklestırmekten sorumlu olan tiplerdir.
        // bu sayede uygulamamızın her gbir kolu uzerıne dusen görevi eksıksız bşr bizimde yerıne getirir.bu sayede zun srelı performsnlı uygulamalar geliştirmiş olursunuz.


        //not:delegateleri asla ve asla classla karıstırmayın.aslında birer classtır
        //tanımalamk için 
        //prototipi

        //1)-onclıkle delegate tanımla geri donus tipi unutma
        //2-)delegate calısması konusundaaa sorumlu olacagı metotları yaz.
        ////3-)ıntance alndıgı asamada ilgili metott delegate baglanır.ve metto yerıne delegate ın  invoke() metodu cagırılıyor.
















    }
}
