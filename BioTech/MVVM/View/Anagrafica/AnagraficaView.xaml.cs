using System.Windows;
using System.Windows.Controls;
using BioTech.Core;

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

    private void Button_Click(object sender, RoutedEventArgs e)
    {

    }

    private void BuildListaPersone()
    {
        ListaPersone.ItemsSource = MongoDbClient.GetPersone();
    }
    
}