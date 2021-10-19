using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ENTITY_BAGLANTISI_ORNEK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Shippers shp = new Shippers();
            shp.CompanyName = "yemek sepeti";
            shp.Phone = "132432";
            NorthwindEntities db = new NorthwindEntities();
            //db.ürünler.Remove(db.ürünler.Find(0));
            db.SaveChanges();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NorthwindEntities db = new NorthwindEntities();
            Shippers shp = new Shippers();
            shp.CompanyName = textBox1.Text;
            shp.Phone = textBox2.Text;
            db.Shippers.Add(shp);
            db.SaveChanges();
            MessageBox.Show("Kayıt basarıyla eklendı.");
        }
    }
}
