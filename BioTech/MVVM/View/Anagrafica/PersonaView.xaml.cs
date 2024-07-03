﻿using BioTech.Core;
using BioTech.MVVM.Model;
using System.Windows;
using System.Windows.Controls;
using BioTech.MVVM.Model.Stores;

namespace BioTech.MVVM.View.Anagrafica;

/// <summary>
///     Interaction logic for GuardaAllenamentoView.xaml
/// </summary>
public partial class PersonaView : UserControl
{
    public PersonaView()
    {
        InitializeComponent();

        PrepareContent();
    }

    private void PrepareContent()
    {
        Persona persona = PersonaStore.CurrentPersona;

        if (persona == null)
            return;

        Nome.Text = persona.Nome;
        Cognome.Text = persona.Cognome;
        Altezza.Text = persona.Altezza.ToString();
        Peso.Text = persona.Peso.ToString();

        DataNascita.Text = persona.DataNascita;
        Indirizzo.Text = persona.Indirizzo;
        Città.Text = persona.Città;
        Professione.Text = persona.Professione;
        Sport.Text = persona.Sport;
        Telefono.Text = persona.Telefono;
    }

    private void StampaButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void SalvaButton_Click(object sender, RoutedEventArgs e)
    {
        var nuovaPersona = new Persona
        {
            Nome = Nome.Text,
            Cognome = Cognome.Text,
            Altezza = double.Parse(Altezza.Text),
            Peso = double.Parse(Peso.Text),
            Sesso = Sesso.Children.OfType<RadioButton>()
               .First(r => r.IsChecked.HasValue && r.IsChecked.Value).Content.ToString(),
            DataNascita = DataNascita.SelectedDate.ToString(),
            Indirizzo = Indirizzo.Text,
            Città = Città.Text,
            Professione = Professione.Text,
            Sport = Sport.Text,
            Telefono = Telefono.Text
        };

        if (MongoDbClient.CheckIfPersonaIsPresente(nuovaPersona))
        {
            MessageBox.Show("È già presente nel database una persona con queste generalità.\nModificare e riprovare!");

            return;
        }

        try
        {
            MongoDbClient.InsertNuovaPersona(nuovaPersona);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Errore durante l'inserimento!");

            return;
        }

        MessageBox.Show("Persona salvata con successo!");

        return;
    }

    private void CleanAndExit_Click(object sender, RoutedEventArgs e)
    {
        PersonaStore.CurrentPersona = null;
    }
}