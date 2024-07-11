using BioTech.MVVM.Model;
using BioTech.MVVM.Model.Stores;
using System.Windows;
using System.Windows.Controls;

namespace BioTech.MVVM.View.FitTest;

/// <summary>
///     Interaction logic for GuardaAllenamentoView.xaml
/// </summary>
public partial class FitTestGeneralità : UserControl
{
    public FitTestGeneralità()
    {
        InitializeComponent();

        PrepareContent();
    }

    private void PrepareContent()
    {
        Persona? persona = PersonaStore.CurrentPersona;

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

    private void CleanAndExit_Click(object sender, RoutedEventArgs e)
    {
        FitTestStore.CurrentFitTest = null;
        FitTestStore.Saved = false;
        PersonaStore.CurrentPersona = null;
        PersonaStore.Saved = false;
    }

    private void Avanti_Click(object sender, RoutedEventArgs e)
    {
        Persona persona = new()
        {
            RefId = !PersonaStore.Saved ? Guid.NewGuid().ToString() : PersonaStore.CurrentPersona!.RefId,
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

        PersonaStore.CurrentPersona = persona;
        FitTestStore.CurrentFitTest!.RefId = persona.RefId;
        FitTestStore.CurrentFitTest.Nome = persona.Nome;
        FitTestStore.CurrentFitTest.Cognome = persona.Cognome;
    }
}