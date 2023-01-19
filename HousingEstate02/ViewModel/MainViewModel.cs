using HousingEstate02.Properties;
using HousingEstate02.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate02.ViewModel
{
    class MainViewModel : ObservableObject
    {
		public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand BoFCViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public BoFCreateViewModel BoFCVM { get; set; }

        private object _currentView;

		public object CurrentView
		{
			get { return _currentView; }
			set { _currentView = value; 
				OnPropertyChanged();
			}
		}

		public MainViewModel() {

			HomeVM = new HomeViewModel();
            BoFCVM = new BoFCreateViewModel();

            CurrentView = HomeVM;
			HomeViewCommand = new RelayCommand(o =>
			{
				CurrentView = HomeVM;
			});
            BoFCViewCommand = new RelayCommand(o =>
            {
                CurrentView = BoFCVM;
            });
        }

    }
}
