using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace OOP_19İLKPROJE
{
    public static class ExtentionMetot
    {
        public static Control.ControlCollection koleksıyon;

        public static void Temizle(Control.ControlCollection koleksıyon)
        {

            foreach (Control item in koleksıyon)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                    //usttuyle aynı işlemdir.
                    //TextBox txt = (TextBox)item;
                    //txt.Clear();
                }
                else if(item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;

                }
                else if (item is PictureBox)
                {
                    PictureBox pcb = (PictureBox)item;
                    pcb.Image = null;
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;

                    //usttuyle aynı bu daha kolay anlasırılır.
                    //DateTimePicker dt = (DateTimePicker)item;
                    //dt.Value;

                }
                else if(item is GroupBox)
                {
                    GroupBox grb =(GroupBox)item;
                    Temizle(grb.Controls);//recursive metot 
                }

            }
        
        }



    }
}
