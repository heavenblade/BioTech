using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Allenamenti;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel;

class HomeViewModel : BaseViewModel
{
    private readonly NavigationStore _navigationStore;

    public object CurrentViewModel => _navigationStore.CurrentView;

    public ICommand NavigateHomeCommand { get; }
    public ICommand NavigateAllenamentiCommand { get; }

    public HomeViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
        _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;

        NavigateHomeCommand = new NavigateCommand<HomeViewModel>(navigationStore, () => new(navigationStore));
        NavigateAllenamentiCommand = new NavigateCommand<AllenamentiViewModel>(navigationStore, () => new(navigationStore));

    }

    private void OnCurrentViewModelChanged()
    {
        OnPropertyChanged(nameof(CurrentViewModel));
    }
}