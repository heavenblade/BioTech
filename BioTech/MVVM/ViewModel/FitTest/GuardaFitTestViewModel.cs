using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.FitTest;

public class GuardaFitTestViewModel : BaseViewModel
{
    public ICommand NavigateFitTestCommand { get; }

    public GuardaFitTestViewModel(NavigationStore navigationStore)
    {
        NavigateFitTestCommand = new NavigateCommand<FitTestViewModel>(navigationStore, () => new(navigationStore));
    }
}