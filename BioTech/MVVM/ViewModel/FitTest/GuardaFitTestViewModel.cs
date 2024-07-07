using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;
using System.Windows.Input;

namespace BioTech.MVVM.ViewModel.FitTest;

class GuardaFitTestViewModel : BaseViewModel
{
    public ICommand NavigateFitTestCommand { get; }

    public GuardaFitTestViewModel(NavigationStore navigationStore)
    {
        NavigateFitTestCommand = new NavigateCommand<FitTestViewModel>(navigationStore, () => new(navigationStore));
    }
}