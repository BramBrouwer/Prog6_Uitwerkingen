using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLeagueApp.WPF.ViewModel
{
    public class SummonerVM
    {
        private PortableLeagueApi.Interfaces.Summoner.ISummoner summoner;

        public SummonerVM(PortableLeagueApi.Interfaces.Summoner.ISummoner summoner)
        {
            // TODO: Complete member initialization
            this.summoner = summoner;
        }
    }
}
