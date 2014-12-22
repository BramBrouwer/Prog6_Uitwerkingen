using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;

namespace DependencyInjectionStarter.Library
{
    public class Triangel : IInstrument
    {
        public string Play()
        {
            return "tring tring tring";
        }
    }
}
