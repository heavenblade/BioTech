using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.Diete;

class DieteViewModel : BaseViewModel
{
    public ICommand NavigateNuovaDietaCommand { get; }
    public ICommand NavigateGuardaDietaCommand { get; }

    public DieteViewModel(NavigationStore navigationStore)
    {
        NavigateNuovaDietaCommand = new NavigateCommand<NuovaDietaViewModel>(navigationStore, () => new(navigationStore));
        NavigateGuardaDietaCommand = new NavigateCommand<GuardaDietaViewModel>(navigationStore, () => new(navigationStore));
    }
}