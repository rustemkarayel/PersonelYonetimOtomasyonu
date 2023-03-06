using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelYonetimOtomasyonu
{
    public interface ICRUD<T>
    {
        void Add(T Entity);
        void Delete(string id);
        List<T> list();
    }
}
