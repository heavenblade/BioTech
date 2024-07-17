using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Alimenti;
using BioTech.MVVM.ViewModel.Allenamenti;
using BioTech.MVVM.ViewModel.Anagrafica;
using BioTech.MVVM.ViewModel.Diete;
using BioTech.MVVM.ViewModel.FitTest;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel;

class HomeViewModel : BaseViewModel
{
    private readonly NavigationStore _navigationStore;

    public object CurrentViewModel => _navigationStore.CurrentView;

    public ICommand NavigateHomeCommand { get; }
    public ICommand NavigateAnagraficaCommand { get; }
    public ICommand NavigateFitTestCommand { get; }
    public ICommand NavigateAllenamentiCommand { get; }
    public ICommand NavigateDieteCommand { get; }
    public ICommand NavigateAlimentiCommand { get; }

    public HomeViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
        _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;

        NavigateHomeCommand = new NavigateCommand<HomeViewModel>(navigationStore, () => new(navigationStore));
        NavigateAnagraficaCommand = new NavigateCommand<AnagraficaViewModel>(navigationStore, () => new(navigationStore));
        NavigateFitTestCommand = new NavigateCommand<FitTestViewModel>(navigationStore, () => new(navigationStore));
        NavigateAllenamentiCommand = new NavigateCommand<AllenamentiViewModel>(navigationStore, () => new(navigationStore));
        NavigateDieteCommand = new NavigateCommand<DieteViewModel>(navigationStore, () => new(navigationStore));
        NavigateAlimentiCommand = new NavigateCommand<AlimentiViewModel>(navigationStore, () => new(navigationStore));
    }

    private void OnCurrentViewModelChanged()
    {
        OnPropertyChanged(nameof(CurrentViewModel));
    }
}