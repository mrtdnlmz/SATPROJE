using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAT.DataAccess.Abstract;
using SAT.Entities.Concrete;

namespace SAT.DataAccess.Concrete.EntityFramework
{
   public class EfYasalOranDal : EfEntityRepositoryBase<YasalOran, SATContext>, IYasalOranDal
    {
    }
}
