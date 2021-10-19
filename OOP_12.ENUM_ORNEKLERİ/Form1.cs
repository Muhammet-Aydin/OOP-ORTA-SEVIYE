using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_12.ENUM_ORNEKLERİ
{
    //public enum Sehirler
    //{
    //istanbul = 10, ankara, izmir, adana, trabzon, eskisehir
    //istanbul = 1, ankara, izmir, adana, trabzon, eskisehir
    //istanbul,
    // ankara,
    // izmir,
    // adana,
    // trabzon,
    // eskisehir
    //}

    public enum Sehirler:byte//sehirler enumununa byte boyutunu verdk.
    {
        istanbul = 1, ankara, izmir, adana, trabzon, eskisehir
    }



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnislemyap_Click(object sender, EventArgs e)
        {
            byte seçilenindex=(byte)Enum.Parse(typeof(Sehirler), listBox1.Text);
            MessageBox.Show(seçilenindex.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(Enum.GetNames(typeof(Sehirler)));

            //Sehirler sehirler = (Sehirler)Enum.Parse(typeof(Sehirler), listBox1.Text);


        }
    }
}
