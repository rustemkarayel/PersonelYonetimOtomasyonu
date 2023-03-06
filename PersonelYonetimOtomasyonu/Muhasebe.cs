using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelYonetimOtomasyonu
{
    public class Muhasebe:Person
    {
        public string HesapNo { get; set; }
        public string Maas { get; set; }
        public Muhasebe(string tc,string adSoyad,string telNo,int yas,string hesapNo,string maas) 
        { 
            TC= tc;
            AdSoyad= adSoyad;
            TelNo= telNo;
            Yas= yas;
            HesapNo= hesapNo;
            Maas= maas;
        }

    }
}
