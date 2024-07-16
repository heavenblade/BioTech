using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.FitTest;

public class FitTestConfrontoViewModel : BaseViewModel
{
    public ICommand NavigateFitTestSummaryCommand { get; }
    public ICommand NavigateFitTestCommand { get; }

    public FitTestConfrontoViewModel(NavigationStore navigationStore)
    {
        NavigateFitTestSummaryCommand = new NavigateCommand<FitTestSummaryViewModel>(navigationStore, () => new(navigationStore));
        NavigateFitTestCommand = new NavigateCommand<FitTestViewModel>(navigationStore, () => new(navigationStore));
    }
}