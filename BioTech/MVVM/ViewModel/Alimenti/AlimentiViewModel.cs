using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.Alimenti;

class AlimentiViewModel : BaseViewModel
{
    public ICommand NavigateNuovoAlimentoCommand { get; }
    public ICommand NavigateGuardaAlimentoCommand { get; }

    public AlimentiViewModel(NavigationStore navigationStore)
    {
        NavigateNuovoAlimentoCommand = new NavigateCommand<NuovoAlimentoViewModel>(navigationStore, () => new(navigationStore));
        NavigateGuardaAlimentoCommand = new NavigateCommand<GuardaAlimentoViewModel>(navigationStore, () => new(navigationStore));
    }
}