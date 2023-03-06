using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelYonetimOtomasyonu
{
    public abstract class Person
    {
        public string TC { get; set; }
        public string AdSoyad { get; set; }
        public string TelNo { get; set; }
        public int Yas { get; set; }
    }
}
