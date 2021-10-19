using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8.STATİC_YAPILAR
{
    public static class Metot
    {
        public static string ClearSesli(this string deger)
        {
            deger = deger.ToLower()
                .Replace("ş", "s")
                .Replace("ö", "o")
                .Replace("ü", "u")
                .Replace("ı", "i")
                .Replace("ğ", "g")
                .Replace("ç", "c");

      
            return   CultureInfo.CurrentCulture.TextInfo.ToTitleCase(deger);


          
          
        }

    }
}
