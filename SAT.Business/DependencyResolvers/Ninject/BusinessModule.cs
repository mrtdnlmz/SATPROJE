using Ninject.Modules;
using SAT.Business.Abstract;
using SAT.Business.Concrete;
using SAT.DataAccess.Abstract;
using SAT.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonelServis>().To<PersonelManager>().InSingletonScope();
            Bind<IPersonelDal>().To<EfPersonelDal>().InSingletonScope();
            Bind<ITazminatServis>().To<TazminatManager>().InSingletonScope();
            Bind<ITazminatDal>().To<EfTazminatDal>().InSingletonScope();
            Bind<IGunHesapServis>().To<GunHesapManager>().InSingletonScope();
            Bind<IKidemTavanDal>().To<EfKidemTavanDal>().InSingletonScope();
        
            Bind<IYasalOranServis>().To<YasalOranManager>().InSingletonScope();
            Bind<IYasalOranDal>().To<EfYasalOranDal>().InSingletonScope();
            Bind<ISosyalYardimServis>().To<SosyalYardimManager>().InSingletonScope();
            Bind<ISosyalYardimDal>().To<EfSosyalYardimDal>().InSingletonScope();
            Bind<IHesapServis>().To<HesapManager>().InSingletonScope();
            Bind<IHesapDal>().To<EfHesapDal>().InSingletonScope();



        }
    }
}
