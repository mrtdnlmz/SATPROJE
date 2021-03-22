using SAT.DataAccess.Abstract;
using SAT.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DataAccess.Concrete.EntityFramework
{
  public  class EfPersonelDal : EfEntityRepositoryBase<Personel, SATContext>, IPersonelDal
    {
    }
}
