using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;
using System.Windows.Input;

namespace BioTech.MVVM.ViewModel.FitTest;

class FitTestViewModel : BaseViewModel
{
    public ICommand NavigateNuovoFitTestCommand { get; }
    public ICommand NavigateGuardaFitTestCommand { get; }

    public FitTestViewModel(NavigationStore navigationStore)
    {
        NavigateNuovoFitTestCommand = new NavigateCommand<NuovoFitTestViewModel>(navigationStore, () => new(navigationStore));
        NavigateGuardaFitTestCommand = new NavigateCommand<GuardaFitTestViewModel>(navigationStore, () => new(navigationStore));
    }
}