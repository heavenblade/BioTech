using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.FitTest;

public class FitTestCirconferenzeViewModel : BaseViewModel
{
    public ICommand NavigateFitTestCommand { get; }
    public ICommand NavigateFitTestPlicheCommand { get; }
    public ICommand NavigateFitTestSummaryCommand { get; }

    public FitTestCirconferenzeViewModel(NavigationStore navigationStore)
    {
        NavigateFitTestCommand = new NavigateCommand<FitTestViewModel>(navigationStore, () => new(navigationStore));
        NavigateFitTestPlicheCommand = new NavigateCommand<FitTestPlicheViewModel>(navigationStore, () => new(navigationStore));
        NavigateFitTestSummaryCommand = new NavigateCommand<FitTestSummaryViewModel>(navigationStore, () => new(navigationStore));
    }
}