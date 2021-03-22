using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SAT.Business.Abstract;
using SAT.DataAccess.Abstract;
using SAT.Entities.Concrete;

namespace SAT.Business.Concrete
{
    public class HesapManager : IHesapServis
    {
        private ISosyalYardimDal _sosyalYardimDal;

        public HesapManager(ISosyalYardimDal sosyalYardimDal)
        {
            _sosyalYardimDal = sosyalYardimDal;
        }



    }
}
