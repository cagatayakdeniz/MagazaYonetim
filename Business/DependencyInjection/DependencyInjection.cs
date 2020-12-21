using DataAccess.Dals;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyInjection
{
    public class DependencyInjection : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonelDal>().To<PersonelDal>();
            Bind<IPersonelService>().To<PersonelService>();

            Bind<IUrunDal>().To<UrunDal>();
            Bind<IUrunService>().To<UrunService>();
        }
    }
}
