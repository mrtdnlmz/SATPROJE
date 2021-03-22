using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAT.Business.Abstract;
using SAT.Business.Utilities;
using SAT.Business.ValidationRules.FluentValidation;
using SAT.DataAccess.Abstract;
using SAT.Entities.Concrete;

namespace SAT.Business.Concrete
{
  public  class PersonelManager:IPersonelServis
    {
        private IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }
                //Business code 
        public List<Personel> GetAll()
        {
                       
            return _personelDal.GetAll();
        }

        public Personel Get(string sicilNo)
        {
            var result = _personelDal.Get(p => p.SicilNo == sicilNo.ToUpper());
            return result;
        }


        public void Add(Personel personel)
        {
            ValidationTool.Validate(new PersonelValidator(), personel);
            _personelDal.Add(personel);
        }

        public void Update(Personel personel)
        {
            ValidationTool.Validate(new PersonelValidator(), personel);
            _personelDal.Update(personel);
        }

        public void Delete(Personel personel)
        {
            try
            {
                _personelDal.Delete(personel);
            }
            catch
            {
                throw new Exception("Silme gerçekleşemedi");
            }

        }

        
    }
}
