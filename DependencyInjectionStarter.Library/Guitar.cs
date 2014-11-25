using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;

namespace DependencyInjectionStarter.Library
{
    [Export(typeof(IInstrument))]
    public class Guitar : IInstrument
    {
        public string Play()
        {
            return "wwhoaaaaaaaa wee wee";
        }
    }
}
