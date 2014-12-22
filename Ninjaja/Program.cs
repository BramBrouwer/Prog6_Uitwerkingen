using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninjaja
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Ninject.IKernel kernel = new StandardKernel(new MyModule());

            var samurai = kernel.Get<Ninja>();

            var kip =  kernel.Get<Kip>();

            samurai.Attack();

            Console.ReadLine();
        }
    }
}
