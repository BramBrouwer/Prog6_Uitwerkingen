using GalaSoft.MvvmLight;
using PortableLeagueApi.Interfaces.Static.Item;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Summoner.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace MyLeagueApp.WPF.ViewModel
{
    /// <summary>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public SummonerVM Summoner { get; set; }

        public ObservableCollection<ItemVM> AllItems { get; set; }

        public ObservableCollection<ItemVM> MyItems { get; set; }


        private StinoLibrary.ILeaugeApi api;
        public MainViewModel()
        {
            api = new StinoLibrary.MyLeaugeApi();

            Summoner = new SummonerVM(api.GetSummonerByName("Links0nder"));

            var items =  api.GetAllItems().Data.Values.Select(i => new ItemVM(i));
            AllItems = new ObservableCollection<ItemVM>(items);
        }



        
    }
}