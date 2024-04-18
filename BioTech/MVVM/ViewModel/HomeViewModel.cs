using System.Windows.Input;
using BioTech.MVVM.Commands;

namespace BioTech.MVVM.ViewModel;

class HomeViewModel : BaseViewModel
{
    private readonly NavigationStore _navigationStore;

    public object CurrentViewModel => _navigationStore.CurrentView;

    public ICommand NavigateHomeCommand { get; }
    public ICommand NavigateAnagraficaCommand { get; }
    public ICommand NavigateAllenamentiCommand { get; }

    public HomeViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
        _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;

        NavigateHomeCommand = new NavigateCommand<HomeViewModel>(navigationStore, () => new(navigationStore));
        NavigateAnagraficaCommand = new NavigateCommand<AnagraficaViewModel>(navigationStore, () => new(navigationStore));
        NavigateAllenamentiCommand = new NavigateCommand<AllenamentiViewModel>(navigationStore, () => new(navigationStore));

    }

    private void OnCurrentViewModelChanged()
    {
        OnPropertyChanged(nameof(CurrentViewModel));
    }
}