using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.Anagrafica;

public class ModificaPersonaViewModel : BaseViewModel
{
    public ICommand NavigateAnagraficaCommand { get; }

    public ModificaPersonaViewModel(NavigationStore navigationStore)
    {
        NavigateAnagraficaCommand = new NavigateCommand<AnagraficaViewModel>(navigationStore, () => new(navigationStore));
    }
}