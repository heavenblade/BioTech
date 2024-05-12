using BioTech.Core;
using BioTech.MVVM.Model;
using System.Windows;
using System.Windows.Controls;

namespace BioTech.MVVM.View.Anagrafica;

/// <summary>
///     Interaction logic for GuardaAllenamentoView.xaml
/// </summary>
public partial class PersonaView : UserControl
{
    public PersonaView() => InitializeComponent();

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
            DataNascita = DataNascita.Text,
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
}