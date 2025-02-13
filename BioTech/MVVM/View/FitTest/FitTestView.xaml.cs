﻿using System.Windows;
using System.Windows.Controls;
using BioTech.Core.Database;
using BioTech.MVVM.Model.Stores;

namespace BioTech.MVVM.View.FitTest;

/// <summary>
///     Interaction logic for FitTestView.xaml
/// </summary>
public partial class FitTestView : UserControl
{
    public FitTestView()
    {
        InitializeComponent();

        BuildListaFitTest(Ricerca.Text);
    }

    private void BuildListaFitTest(string ricerca)
    {
        var fitTestList = ricerca.Equals("") ? MongoDbClient.GetFitTest() : MongoDbClient.GetFitTestWithFilter(ricerca.ToLower());

        foreach (var fitTest in fitTestList)
            fitTest.DataString = fitTest.Data.ToShortDateString();

        ListaFitTest.ItemsSource = fitTestList;
    }

    private void OnSelectedFitTest(object sender, RoutedEventArgs e)
    {
        ButtonGuarda.IsEnabled = true;
        ButtonCopia.IsEnabled = true;
        ButtonModifica.IsEnabled = true;
    }

    private void NuovoFitTest_Click(object sender, RoutedEventArgs e)
    {
        DateTime now = DateTime.Now;

        FitTestStore.CurrentFitTest = new()
        {
            Data = now.AddHours(TimeZoneInfo.Local.IsDaylightSavingTime(now) ? 2 : 1)
        };

        FitTestStore.Saved = false;
        PersonaStore.Saved = false;
    }

    private void GuardaFitTest_Click(object sender, RoutedEventArgs e)
    {
        var selectedFitTest = ListaFitTest.SelectedItem as Model.FitTest;

        string nome = selectedFitTest!.Nome;
        string cognome = selectedFitTest!.Cognome;
        DateTime data = selectedFitTest!.Data;

        FitTestStore.CurrentFitTest = MongoDbClient.FindFitTest(nome, cognome, data);
    }

    private void CopiaFitTest_Click(object sender, RoutedEventArgs e)
    {
        var selectedFitTest = ListaFitTest.SelectedItem as Model.FitTest;

        string nome = selectedFitTest!.Nome;
        string cognome = selectedFitTest!.Cognome;
        DateTime data = selectedFitTest!.Data;

        var fitTest = MongoDbClient.FindFitTest(nome, cognome, data);

        var now = DateTime.Now;
        fitTest.Data = now.AddHours(TimeZoneInfo.Local.IsDaylightSavingTime(now) ? 2 : 1);

        MongoDbClient.InsertFitTest(fitTest);

        FitTestStore.CurrentFitTest = fitTest;
        FitTestStore.Saved = true;

        BuildListaFitTest(Ricerca.Text);
    }

    private void ModificaFitTest_Click(object sender, RoutedEventArgs e)
    {
        var selectedFitTest = ListaFitTest.SelectedItem as Model.FitTest;

        string nome = selectedFitTest!.Nome;
        string cognome = selectedFitTest!.Cognome;
        DateTime data = selectedFitTest!.Data;

        FitTestStore.CurrentFitTest = MongoDbClient.FindFitTest(nome, cognome, data);
        FitTestStore.Saved = true;
        PersonaStore.CurrentPersona = MongoDbClient.GetPersona(FitTestStore.CurrentFitTest.RefId);
        PersonaStore.Saved = true;
    }

    private void Ricerca_TextChanged(object sender, TextChangedEventArgs e) =>
        BuildListaFitTest(Ricerca.Text);

    private void ButtonReset_Click(object sender, RoutedEventArgs e)
    {
        Ricerca.Text = "";
        BuildListaFitTest(Ricerca.Text);
    }
}