using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.FitTest;

public class FitTestCirconferenzeViewModel : BaseViewModel
{
    public ICommand NavigateFitTestPlicheCommand { get; }
    // avanti

    public FitTestCirconferenzeViewModel(NavigationStore navigationStore)
    {
        NavigateFitTestPlicheCommand = new NavigateCommand<FitTestPlicheViewModel>(navigationStore, () => new(navigationStore));
    }
}