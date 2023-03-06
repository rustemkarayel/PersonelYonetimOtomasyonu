using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelYonetimOtomasyonu
{
    public class Bireysel:Person
    {
        public string SatisHedefi { get; set; }
        public string Prim { get; set; }
        public Bireysel(string tc,string adSoyad,string telNo,int yas,string satisHedefi,string prim) 
        { 
            TC = tc;
            AdSoyad = adSoyad;
            TelNo = telNo;
            Yas= yas;
            SatisHedefi= satisHedefi;
            Prim = prim;
        }   
    }
}
