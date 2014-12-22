using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninjaja
{
    public class Ninja
    {
        IWeapon[] Weapons { get; set; }

        public Ninja(IWeapon[] weapons)
        {
            this.Weapons = weapons;
        }

        public void Attack()
        {
            foreach (var w in Weapons)
            {
                w.Strike();
            }
        }
    }
}
