using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;
using System.Windows.Input;

namespace BioTech.MVVM.ViewModel.FitTest;

class FitTestViewModel : BaseViewModel
{
    public ICommand NavigateGuardaFitTestCommand { get; }
    public ICommand NavigateFitTestGeneralitàCommand { get; }

    public FitTestViewModel(NavigationStore navigationStore)
    {
        NavigateGuardaFitTestCommand = new NavigateCommand<GuardaFitTestViewModel>(navigationStore, () => new(navigationStore));
        NavigateFitTestGeneralitàCommand = new NavigateCommand<FitTestGeneralitàViewModel>(navigationStore, () => new(navigationStore));
    }
}