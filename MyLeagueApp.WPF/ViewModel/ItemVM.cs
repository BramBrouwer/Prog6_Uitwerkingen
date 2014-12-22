using PortableLeagueApi.Interfaces.Static.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLeagueApp.WPF.ViewModel
{
    public class ItemVM
    {
        private IItem _item;

        public string Name
        {
            get { return _item.Name; }
        }

        public int Price
        {
            get { return _item.Gold.Total; }
        }

        public ItemVM(IItem item)
        {
            // TODO: Complete member initialization
            this._item = item;
        }
    }
}
