using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_16IComparable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Takım> puandurumu = new List<Takım>();//Takım tipimin ııcındekı nesnelerı tutmak ıcın list olusturduk ısmı puandurumu.



        private void listWiewDoldur()
        {
            listView1.Items.Clear();
            int sıralama = 1;
            foreach (var item in puandurumu)
            {
                ListViewItem li = new ListViewItem(sıralama.ToString());
                li.SubItems.Add(item.Adi);
                li.SubItems.Add(item.Averaji.ToString());
                li.SubItems.Add(item.puani.ToString());
                sıralama++;
                listView1.Items.Add(li);
                
                //MessageBox.Show(item.Adi +item.Averaji +item.puani);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            puandurumu.Add(new Takım { Adi = "Galatasaray", Averaji = 66, puani = 80 });
            puandurumu.Add(new Takım { Adi = "Fenerbahçe", Averaji = 20, puani = 34 });
            puandurumu.Add(new Takım { Adi = "Beşiktaş", Averaji = 40, puani = 66 });
            puandurumu.Add(new Takım { Adi = "TrabzonSpor", Averaji = 45, puani = 89 });
            puandurumu.Add(new Takım { Adi = "Eskişehir", Averaji = 67, puani = 83 });
            puandurumu.Add(new Takım { Adi = "İBB", Averaji = 76, puani = 86 });
            puandurumu.Add(new Takım { Adi = "Başakşehir", Averaji = 86, puani = 45 });
            puandurumu.Add(new Takım { Adi = "Karagümrük", Averaji = 16, puani = 34 });
            puandurumu.Add(new Takım { Adi = "Antalya", Averaji = 62, puani = 66 });
            puandurumu.Add(new Takım { Adi = "ManisaSpor", Averaji = 33, puani = 70 });

            listWiewDoldur();
        }
        bool puanBüyüktenKüçüğemi = true;
        bool averajBüyüktenKüçüğemi = true;
        bool adBüyüktenKüçüğemi = true;



        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 1:
                    if (adBüyüktenKüçüğemi)
                    {
                        puandurumu.Sort(new AdaGöreKüçüktenBüyüğesıralama());
                        adBüyüktenKüçüğemi = false;
                    }
                    else
                    {
                      
                        puandurumu.Sort(new AdaGöreBüyüktenKüçüğesıralama());
                        adBüyüktenKüçüğemi = true;
                    }
                    break;
                case 2:
                    if (averajBüyüktenKüçüğemi)
                    {
                        puandurumu.Sort(new AverajaGöreküçüktenBüyüğeSıralama());
                        averajBüyüktenKüçüğemi = false;
                    }
                    else
                    {
                        puandurumu.Sort(new AverajaGöreBüyüktenKüçüğeSıralama());
                        averajBüyüktenKüçüğemi = true;
                    }
                    break;
                case 3:
                    if (puanBüyüktenKüçüğemi)
                    {
                        puandurumu.Sort(new PuanıKüçüktenBüyüğeSırala());

                        puanBüyüktenKüçüğemi = false;


                    }
                    else
                    {
                        puandurumu.Sort();
                        puanBüyüktenKüçüğemi = true;

                    }
                    break;


                default:
                    break;
            }
            listWiewDoldur();



        }

     
    }
}
       
    
