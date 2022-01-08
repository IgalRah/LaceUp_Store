using LaceUp.Core;

namespace LaceUp.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand LifeStyleViewCommand { get; set; }
        public RelayCommand JordanViewCommand { get; set; }
        public RelayCommand WalkingViewCommand { get; set; }
        public RelayCommand GymViewCommand { get; set; }


        public HomeViewModel HomeVm { get; set; }
        public LifeStyleViewModel LifeStyleVm { get; set; }
        public JordanViewModel JordanVm { get; set; }
        public WalkingViewModel WalkingVm { get; set; }
        public GymViewModel GymVm { get; set; }


        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            LifeStyleVm = new LifeStyleViewModel();
            JordanVm = new JordanViewModel();
            WalkingVm = new WalkingViewModel();
            GymVm = new GymViewModel();


            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o => 
            {
                CurrentView = HomeVm;
            });

            LifeStyleViewCommand = new RelayCommand(o =>
            {
                CurrentView = LifeStyleVm;
            });

            JordanViewCommand = new RelayCommand(o =>
            {
                CurrentView = JordanVm;
            });

            WalkingViewCommand = new RelayCommand(o =>
            {
                CurrentView = WalkingVm;
            });

            GymViewCommand = new RelayCommand(o =>
            {
                CurrentView = GymVm;
            });
        }
    }

}
