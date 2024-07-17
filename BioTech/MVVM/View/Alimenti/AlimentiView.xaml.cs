using System.Windows;
using System.Windows.Controls;

namespace BioTech.MVVM.View.Alimenti;

/// <summary>
///     Interaction logic for AlimentiView.xaml
/// </summary>
public partial class AlimentiView : UserControl
{
    public AlimentiView()
    {
        InitializeComponent();

        PrepareContent();
    }

    private void PrepareContent()
    {

    }

    private void BuildListaAlimenti(string ricerca)
    {

    }

    private void OnSelectedAlimento(object sender, RoutedEventArgs e)
    {

    }

    private void NuovoAlimento_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Ricerca_TextChanged(object sender, TextChangedEventArgs e) =>
        BuildListaAlimenti(Ricerca.Text);

    private void ButtonReset_Click(object sender, RoutedEventArgs e)
    {
        Ricerca.Text = "";
        BuildListaAlimenti(Ricerca.Text);
    }
}