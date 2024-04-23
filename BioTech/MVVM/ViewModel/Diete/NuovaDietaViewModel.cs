﻿using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.Diete;

public class NuovaDietaViewModel : BaseViewModel
{
    public ICommand NavigateDieteCommand { get; }

    public NuovaDietaViewModel(NavigationStore navigationStore)
    {
        NavigateDieteCommand = new NavigateCommand<DieteViewModel>(navigationStore, () => new(navigationStore));
    }
}