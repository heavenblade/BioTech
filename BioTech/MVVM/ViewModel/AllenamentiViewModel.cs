using System.Windows.Input;
using BioTech.MVVM.Commands;

namespace BioTech.MVVM.ViewModel;

class AllenamentiViewModel : BaseViewModel
{
    public ICommand NavigateAllenamentiCommand { get; }

    public AllenamentiViewModel(NavigationStore navigationStore)
    {
        NavigateAllenamentiCommand = new NavigateCommand<AllenamentiViewModel>(navigationStore, () => new(navigationStore));
    }

}