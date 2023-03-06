using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelYonetimOtomasyonu
{
    public class BireyselIslem : ICRUD<Bireysel>
    {
        public void Add(Bireysel Entity)
        {
            DBContext.bireyseller.Add(Entity);
        }

        public void Delete(string id)
        {
            var bul=DBContext.bireyseller.FirstOrDefault(x=> x.TC == id);
            DBContext.bireyseller.Remove(bul);
        }

        public List<Bireysel> list()
        {
            return DBContext.bireyseller.ToList();
        }
    }
}
