using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MusicCollectionMVVM
{
    public class SongListviewModel : INotifyPropertyChanged
    {
        ISongRepository songRepository;

        private SongViewModel _songViewModel;
        public SongViewModel SongViewModel { get{ return _songViewModel;}
            set
            {
                _songViewModel = value;
                OnPropertyChanged("SongViewModel");
            }
        }

        public ObservableCollection<SongViewModel> Songs { get; set; }

        public ICommand AddSong { get; set; }

        public ICommand ClearSong { get; set; }

        public SongListviewModel()
        {
            songRepository = new DummySongRepository();
            var songList = songRepository.ToList().Select(s => new SongViewModel(s));

            SongViewModel = new SongViewModel();
            Songs = new ObservableCollection<SongViewModel>(songList);

            ClearSong = new RelayCommand(ClearThesong, CanClearSong);
            AddSong = new RelayCommand(AddNewSong, CanAddSong);
        }

        private void ClearThesong()
        {
            SongViewModel = new SongViewModel();
        }

        private bool CanClearSong()
        {
            return true;
        }


        private void AddNewSong()
        {
            var svm = new SongViewModel();

            svm.Artist = SongViewModel.Artist;
            svm.Id = SongViewModel.Id;
            svm.Title = SongViewModel.Title;

            Songs.Add(svm);
        }

        private bool CanAddSong()
        {
            if(SongViewModel.Artist == null)
                return false;

            if (SongViewModel.Id <= 0)
                return false;

            if (SongViewModel.Title == null)
                return false;

            return true;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
