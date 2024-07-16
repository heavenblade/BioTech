﻿using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.Diete;

public class ModificaDietaViewModel : BaseViewModel
{
    public ICommand NavigateDieteCommand { get; }

    public ModificaDietaViewModel(NavigationStore navigationStore)
    {
        NavigateDieteCommand = new NavigateCommand<DieteViewModel>(navigationStore, () => new(navigationStore));
    }
}