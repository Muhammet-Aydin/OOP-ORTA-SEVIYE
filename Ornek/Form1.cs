using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
      
        }
        
    
        

       abstract class Abstractclass
        {
            public int MyProperty { get; set; }
            public void x()
            {
            
            
            
            }

            public abstract int y();


           public abstract int MyProperty2 { get; set; }

        }


        class MyClass : Abstractclass
        {
           
           
            public override int MyProperty2 { get ; set ; }

            public override int y()
            {
                return 0;
            }
        }
    }
}
