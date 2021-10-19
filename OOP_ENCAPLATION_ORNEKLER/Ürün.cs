using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ENCAPLATION_ORNEKLER
{

    //nesnenin fieldlarına yapılan erısımı kontrol altına alınmasını ve bu kontrolün nesnenın kendısı tarafından yapılmasını saglayan yapıdır.Amaç Fİeldları private yaparak bu alanlardan dısarıya erısımı onlemek tabi bunu onlerkenden get ve set metotları ile kontrolü saglamaktr.
    //kullanıcının ıslemlerıı daha kolay gerçekleştırebilmesi için bazı işlemleri kapsulleyerek tek işlem gibi göstermesidir.
    //örnegin veri tabanı baglantı ıslemın biz sadece baglantı bilgilerini degişkeni kullanırken open() adındakı metotdu kullanmkatayız 


    public class Ürün
    {
        int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        string _Acıklama;
        public string Acıklama
        {
            get
            {
                return _Acıklama;
            }
            set
            {
                _Acıklama = value;

            }
        }
        double _fiyat;
        public double Fiyat
        {
            get
            {
                return _fiyat;

            }
            set
            {
                if (value < 0)
                {
                    System.Windows.Forms.MessageBox.Show("lütfen 0 dan buyuk bir fiyat degeri giriniz.");
                }
                else
                {
                    _fiyat = value;
                }
            }

        }



    }
}
