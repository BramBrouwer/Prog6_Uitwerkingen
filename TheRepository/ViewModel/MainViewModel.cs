using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace TheRepository.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private ICarRepository _carRepository;

        public ObservableCollection<CarVM> MyCars { get; set; }

        public ICommand SaveChangesCommand { get; set; }

        public MainViewModel(ICarRepository carRepository)
        {
            this._carRepository = carRepository;
        }

        public double TotalePrijs
        {
            get
            {
                return _carRepository.GetAllCars().Sum(c => c.Prijs);
            }
        }


        public void SaveChanges()
        {
            _carRepository.SetAllCars(MyCars.Select(c => c.ToCar()));
        }

    }
}