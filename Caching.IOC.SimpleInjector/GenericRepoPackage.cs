using Application;
using SimpleInjector;
using SimpleInjector.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caching.IOC.SimpleInjector
{
    public class GenericRepoPackage : IPackage
    {
        public void RegisterServices(Container container)
        {
            //container.Register<IGenericRepo, GenericRepo>(Lifestyle.Scoped);
            //container.RegisterDecorator<IGenericRepo, CachedGenericRepo>(Lifestyle.Scoped);

        }
    }
}
