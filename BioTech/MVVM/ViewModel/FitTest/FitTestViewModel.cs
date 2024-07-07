using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;
using System.Windows.Input;

namespace BioTech.MVVM.ViewModel.FitTest;

class FitTestViewModel : BaseViewModel
{
    public ICommand NavigateFitTestGeneralitàCommand { get; }
    public ICommand NavigateFitTestPlicheCommand { get; }
    public ICommand NavigateFitTestSummaryCommand { get; }

    public FitTestViewModel(NavigationStore navigationStore)
    {
        NavigateFitTestGeneralitàCommand = new NavigateCommand<FitTestGeneralitàViewModel>(navigationStore, () => new(navigationStore));
        NavigateFitTestPlicheCommand = new NavigateCommand<FitTestPlicheViewModel>(navigationStore, () => new(navigationStore));
        NavigateFitTestSummaryCommand = new NavigateCommand<FitTestSummaryViewModel>(navigationStore, () => new(navigationStore));
    }
}