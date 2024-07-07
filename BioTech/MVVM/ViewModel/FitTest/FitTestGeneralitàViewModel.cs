using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.FitTest;

public class FitTestGeneralitàViewModel : BaseViewModel
{
    public ICommand NavigateFitTestCommand { get; }
    public ICommand NavigateFitTestPlicheCommand { get; }

    public FitTestGeneralitàViewModel(NavigationStore navigationStore)
    {
        NavigateFitTestCommand = new NavigateCommand<FitTestViewModel>(navigationStore, () => new(navigationStore));
        NavigateFitTestPlicheCommand = new NavigateCommand<FitTestPlicheViewModel>(navigationStore, () => new(navigationStore));
    }
}