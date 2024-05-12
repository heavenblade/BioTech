using BioTech.MVVM.Commands;
using System.Windows.Input;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.Anagrafica;

public class AnagraficaViewModel : BaseViewModel
{
    public ICommand NavigateNuovaPersonaCommand { get; }
    public ICommand NavigateGuardaPersonaCommand { get; }
    public ICommand NavigateModificaPersonaCommand { get; }

    public AnagraficaViewModel(NavigationStore navigationStore)
    {
        NavigateNuovaPersonaCommand = new NavigateCommand<NuovaPersonaViewModel>(navigationStore, () => new(navigationStore));
        NavigateGuardaPersonaCommand = new NavigateCommand<GuardaPersonaViewModel>(navigationStore, () => new(navigationStore));
        NavigateModificaPersonaCommand = new NavigateCommand<ModificaPersonaViewModel>(navigationStore, () => new(navigationStore));
    }

}