using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionStarter.Library
{
    public class RockBand
    {
        /// <summary>
        /// Laatste opdracht IOC .net 
        /// </summary>
        [ImportMany(typeof(IInstrument))] 
        private IEnumerable<IInstrument> instruments;

        public RockBand()
        {
 
        }

        public RockBand(List<IInstrument> instruments)
        {
            this.instruments = instruments;
        }

        public void DoSoundCheck()
        {
            foreach (IInstrument i in instruments)
            {
                Console.WriteLine(i.Play());
            }
        }
    }
}
