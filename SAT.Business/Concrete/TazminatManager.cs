using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAT.Business.Abstract;
using SAT.DataAccess.Abstract;
using SAT.Entities.Concrete;

namespace SAT.Business.Concrete
{
    public class TazminatManager : ITazminatServis
    {
        private ITazminatDal _tazminatDal;

        public TazminatManager(ITazminatDal tazminatDal)
        {
            _tazminatDal = tazminatDal;
        }


        public List<Tazminat> GetAll()
        {
            //Business code            
            return _tazminatDal.GetAll();
        }


    }
}
