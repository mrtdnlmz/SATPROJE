using SAT.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.Business.Abstract
{
   public interface IPersonelServis
    {
        List<Personel> GetAll();
        Personel Get(string sicilNo);
        void Add(Personel personel);
        void Update(Personel personel);
        void Delete(Personel personel);
      
    }
}
