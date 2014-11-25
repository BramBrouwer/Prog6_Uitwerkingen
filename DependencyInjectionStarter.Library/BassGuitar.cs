using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjectionStarter.Library
{
    public class BassGuitar : IInstrument
    {
        public string Play()
        {
            return "Boooow Boooow Boooooow";
        }
    }
}
