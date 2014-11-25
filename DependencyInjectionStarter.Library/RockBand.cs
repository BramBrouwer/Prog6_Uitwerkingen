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
        private Guitar guitar = new Guitar();
        private BassGuitar bassGuitar = new BassGuitar();
        private Drums drums = new Drums();
        private Vocal vocal = new Vocal();

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
