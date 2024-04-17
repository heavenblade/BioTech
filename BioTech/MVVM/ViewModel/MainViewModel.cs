using BioTech.Core;

namespace BioTech.MVVM.ViewModel;

internal class MainViewModel : ObservableObject
{
    public HomeViewModel HomeViewModel { get; set; }
    public AnagraficaViewModel AnagraficaViewModel { get; set; }
    public FitTestViewModel FitTestViewModel { get; set; }
    public DieteViewModel DieteViewModel { get; set; }
    public AllenamentiViewModel AllenamentiViewModel { get; set; }
    public AlimentiViewModel AlimentiViewModel { get; set; }


    public RelayCommand HomeViewCommand { get; set; }
    public RelayCommand AnagraficaViewCommand { get; set; }
    public RelayCommand FitTestViewCommand { get; set; }
    public RelayCommand DieteViewCommand { get; set; }
    public RelayCommand AllenamentiViewCommand { get; set; }
    public RelayCommand AlimentiViewCommand { get; set; }



    private object _currentView;

    public object CurrentView
    {
        get => _currentView;
        private set
        {
            _currentView = value;
            OnPropertyChanged();
        }
    }

    public MainViewModel()
    {
        HomeViewModel = new();
        AnagraficaViewModel = new();
        FitTestViewModel = new();
        DieteViewModel = new();
        AllenamentiViewModel = new();
        AlimentiViewModel = new();

        HomeViewCommand = new(o =>
        {
            CurrentView = HomeViewModel;
        });

        AnagraficaViewCommand = new(o =>
        {
            CurrentView = AnagraficaViewModel;
        });

        FitTestViewCommand = new(o =>
        {
            CurrentView = FitTestViewModel;
        });

        DieteViewCommand = new(o =>
        {
            CurrentView = DieteViewModel;
        });

        AllenamentiViewCommand = new(o =>
        {
            CurrentView = AllenamentiViewModel;
        });

        AlimentiViewCommand = new(o =>
        {
            CurrentView = AlimentiViewModel;
        });

        CurrentView = HomeViewModel;
    }
}