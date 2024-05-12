using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.Anagrafica;

public class GuardaPersonaViewModel : BaseViewModel
{
    public ICommand NavigateAnagraficaCommand { get; }

    public GuardaPersonaViewModel(NavigationStore navigationStore)
    {
        NavigateAnagraficaCommand = new NavigateCommand<AnagraficaViewModel>(navigationStore, () => new(navigationStore));
    }
}