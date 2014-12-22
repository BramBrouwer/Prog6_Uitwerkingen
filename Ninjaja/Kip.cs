using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ninjaja
{
    public class Kip
    {
        public IWeapon weapon { get; set; 
        
        }
        public Kip(IWeapon weapon)
        {
            this.weapon = weapon;
        }
    }
}
