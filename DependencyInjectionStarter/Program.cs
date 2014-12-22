using DependencyInjectionStarter.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionStarter
{
    class Program 
    {

        static void Main(string[] args)
        {
            var catalog = new AssemblyCatalog(Assembly.GetAssembly(typeof(IInstrument)));

            var container = new CompositionContainer(catalog);

            var list = container.GetExportedValues<IInstrument>();

            var rockBand = new RockBand();

            container.ComposeParts(rockBand);

            rockBand.DoSoundCheck();

            Console.ReadLine();
        }


    }
}
