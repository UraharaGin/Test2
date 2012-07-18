using Ninject.Modules;
using Test.Test.Core;
using Test.Test.Domain;
using Test.Test.Tools;

namespace Test.Test.NInjectModules
{
    public class MainNinjectModule :NinjectModule
    {
        public override void Load()
        {
            Bind<DataBaseContext>().ToMethod(it => new DataBaseContext());
            Bind<IRepository>().To<Repository>();
            Bind<IAuthentificator>().To<Authentificator>();
        }
    }
}