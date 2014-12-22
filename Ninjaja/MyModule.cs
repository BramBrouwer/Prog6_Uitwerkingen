using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninjaja
{
    public class MyModule : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IWeapon>().To<VliegeMepper>();
        }
    }
}
