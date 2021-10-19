using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_13.INTERFACE_YAPISI
{
    public partial class Form1 : Form
    {
        Kaleci klc = new Kaleci()
        {
            AdSoyad = "muslera",
            Agresiflik = 5,
            FormaNumarasi = "01",
            Millimi = true,
            Reflex = 100,
            SutGucu = 75,


        };



        Defans defans1 = new Defans()
        {
            AdSoyad = "emre",
            Agresiflik = 5,
            FormaNumarasi = "10",
            Millimi = false,
            Reflex = 70,
            SutGucu = 100
        };

        Forvet frv = new Forvet()
        {
            AdSoyad = "muhammet aydın",
            Agresiflik = 5,
            FormaNumarasi = "10",
            Millimi = false,
            Reflex = 70,
            SutGucu = 100
        };


        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listBox1.SelectedItem.GetType()==typeof(Kaleci))
            //{
            //    Kaleci k = listBox1.SelectedItem as Kaleci;
            //    foreach (var item in k.GetType().GetProperties())
            //    {
            //        Label lbl = new Label();
            //        lbl.Text = string.Format(item.Name + ":" + item.GetValue(k));
            //        lbl.AutoSize = false;
            //        lbl.Width = flowLayoutPanel1.Width;
            //        flowLayoutPanel1.Controls.Add(lbl);
            //    }
            //}
            //else if (listBox1.SelectedItem.GetType()==typeof(Defans))
            //{
            //    Defans d = listBox1.SelectedItem as Defans;
            //    foreach (var item in d.GetType().GetProperties())
            //    {
            //        Label lbl = new Label();
            //        lbl.Text = string.Format(item.Name + ":" + item.GetValue(d));
            //        lbl.AutoSize = false;
            //        lbl.Width = flowLayoutPanel1.Width;
            //        flowLayoutPanel1.Controls.Add(lbl);
            //    }
            //}
            if (listBox1.SelectedItem != null && listBox1.SelectedItem.GetType().GetInterface("IFutbolcu") != null)
            {

                IFutbolcu futbolcu = (IFutbolcu)listBox1.SelectedItem;

                foreach (PropertyInfo item in futbolcu.GetType().GetProperties())

                {
                    Label lbl = new Label();
                    lbl.Text = string.Format(item.Name + ":" + item.GetValue(futbolcu));
                    lbl.AutoSize = false;
                    lbl.Width = flowLayoutPanel1.Width;
                    flowLayoutPanel1.Controls.Add(lbl);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(klc);
            listBox1.Items.Add(defans1);
            listBox1.Items.Add(frv);
        }
    }
}

