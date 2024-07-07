using BioTech.Core;
using BioTech.MVVM.Model;
using System.Windows;
using System.Windows.Controls;
using BioTech.MVVM.Model.Stores;

namespace BioTech.MVVM.View.Anagrafica;

/// <summary>
///     Interaction logic for GuardaAllenamentoView.xaml
/// </summary>
public partial class EditPersona : UserControl
{
    public EditPersona()
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
        Persona persona = new()
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

        if (BaseDataChanged(PersonaStore.CurrentPersona, persona))
        {
            try
            {
                MongoDbClient.InsertNuovaPersona(persona);

                MongoDbClient.DeletePersona(PersonaStore.CurrentPersona);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'aggiornamento!");

                return;
            }
        }
        else
        {
            try
            {
                MongoDbClient.UpdatePersona(persona);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'aggiornamento!");

                return;
            }
        }

        MessageBox.Show("Persona salvata con successo!");

        return;
    }

    private bool BaseDataChanged(Persona saved, Persona current)
    {
        if (!saved.Nome.Equals(current.Nome))
            return true;
        if (!saved.Cognome.Equals(current.Cognome))
            return true;
        if (!saved.DataNascita.Equals(current.DataNascita))
            return true;
        if (!saved.Città.Equals(current.Città))
            return true;
        if (!saved.Telefono.Equals(current.Telefono))
            return true;

        return false;
    }

    private void CleanAndExit_Click(object sender, RoutedEventArgs e)
    {
        PersonaStore.CurrentPersona = null;
    }
}