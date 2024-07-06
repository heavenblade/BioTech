using System.Windows;
using System.Windows.Controls;
using BioTech.Core;

namespace BioTech.MVVM.View.FitTest;

/// <summary>
///     Interaction logic for FitTestView.xaml
/// </summary>
public partial class FitTestView : UserControl
{
    public FitTestView()
    {
        InitializeComponent();

        BuildListaFitTest();
    }

    private void BuildListaFitTest() =>
        ListaFitTest.ItemsSource = MongoDbClient.GetFitTest();

    private void OnSelectedFitTest(object sender, RoutedEventArgs e)
    {
        ButtonGuarda.IsEnabled = true;
    }

    private void GuardaFitTest_OnClick(object sender, RoutedEventArgs e)
    {

    }

    private void Ricerca_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void ButtonReset_OnClick(object sender, RoutedEventArgs e)
    {
        Ricerca.Text = "";
        BuildListaFitTest();
    }
}