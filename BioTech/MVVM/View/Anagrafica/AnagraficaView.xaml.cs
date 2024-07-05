using System.Windows;
using System.Windows.Controls;
using BioTech.Core;
using BioTech.MVVM.Model;
using BioTech.MVVM.Model.Stores;

namespace BioTech.MVVM.View.Anagrafica;

/// <summary>
///     Interaction logic for AnagraficaView.xaml
/// </summary>
public partial class AnagraficaView : UserControl
{
    public AnagraficaView()
    {
        InitializeComponent();

        BuildListaPersone();
    }

    private void BuildListaPersone()
    {
        ListaPersone.ItemsSource = MongoDbClient.GetPersone();
    }

    private void GuardaPersona_OnClick(object sender, RoutedEventArgs e)
    {
        if (ListaPersone.SelectedItems.Count == 0)
        {
            MessageBox.Show("Selezionare prima una persona dalla lista!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            return;
        }

        var selectedPersona = ListaPersone.SelectedItem as Persona;

        string nome = selectedPersona!.Nome;
        string cognome = selectedPersona!.Cognome; 
        string città = selectedPersona!.Città;
        string telefono = selectedPersona!.Telefono;

        PersonaStore.CurrentPersona = MongoDbClient.FindPersona(nome, cognome, città, telefono);
    }
    
    private void ButtonReset_OnClick(object sender, RoutedEventArgs e)
    {
        Ricerca.Text = "";
        ListaPersone.ItemsSource = MongoDbClient.GetPersone();
    }

    private void Ricerca_TextChanged(object sender, TextChangedEventArgs e)
    {
        string ricerca = Ricerca.Text;

        if (ricerca.Length == 0)
        {
            ListaPersone.ItemsSource = MongoDbClient.GetPersone();

            return;
        }

        ListaPersone.ItemsSource = MongoDbClient.GetPersoneWithFilter(ricerca.ToLower());
    }
}