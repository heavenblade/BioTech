using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.Anagrafica;

public class EditPersonaViewModel : BaseViewModel
{
    public ICommand NavigateAnagraficaCommand { get; }

    public EditPersonaViewModel(NavigationStore navigationStore)
    {
        NavigateAnagraficaCommand = new NavigateCommand<AnagraficaViewModel>(navigationStore, () => new(navigationStore));
    }
}