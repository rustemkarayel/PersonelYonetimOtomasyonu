using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelYonetimOtomasyonu
{
    public class MuhasebeIslem : ICRUD<Muhasebe>
    {
        public void Add(Muhasebe Entity)
        {
            DBContext.muhasebeler.Add(Entity);
        }

        public void Delete(string id)
        {
            var bul = DBContext.muhasebeler.FirstOrDefault(x => x.TC == id);
            DBContext.muhasebeler.Remove(bul);
        }

        public List<Muhasebe> list()
        {
            return DBContext.muhasebeler.ToList();
        }
    }
}
