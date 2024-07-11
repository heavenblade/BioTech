using BioTech.MVVM.Model.Stores;
using System.Windows;
using System.Windows.Controls;
using BioTech.MVVM.Model;

namespace BioTech.MVVM.View.FitTest;

/// <summary>
///     Interaction logic for GuardaAllenamentoView.xaml
/// </summary>
public partial class FitTestPliche : UserControl
{
    public FitTestPliche()
    {
        InitializeComponent();

        PrepareContent();
    }

    private void PrepareContent()
    {
        var fitTest = FitTestStore.CurrentFitTest;

        if (fitTest?.Pliche == null)
            return;

        Bicipite.Text = fitTest.Pliche.Bicipite.ToString();
        Tricipite.Text = fitTest.Pliche.Tricipite.ToString();
        Torace.Text = fitTest.Pliche.Torace.ToString();
        Sottoscapola.Text = fitTest.Pliche.Sottoscapola.ToString();
        Soprailio.Text = fitTest.Pliche.Soprailio.ToString();
        Ombelico.Text = fitTest.Pliche.Ombelico.ToString();
        Coscia.Text = fitTest.Pliche.Coscia.ToString();
        CosciaEsterna.Text = fitTest.Pliche.CosciaEsterna.ToString();
    }

    private void Indietro_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Avanti_Click(object sender, RoutedEventArgs e)
    {
        var now = DateTime.Now;

        Pliche pliche = new()
        {
            Bicipite = double.Parse(Bicipite.Text),
            Tricipite = double.Parse(Tricipite.Text),
            Torace = double.Parse(Torace.Text),
            Sottoscapola = double.Parse(Sottoscapola.Text),
            Soprailio = double.Parse(Soprailio.Text),
            Ombelico = double.Parse(Ombelico.Text),
            Coscia = double.Parse(Coscia.Text),
            CosciaEsterna = double.Parse(CosciaEsterna.Text)
        };

        FitTestStore.CurrentFitTest!.Pliche = pliche;
    }

    private void CleanAndExit_Click(object sender, RoutedEventArgs e)
    {
        FitTestStore.CurrentFitTest = null;
        FitTestStore.Saved = false;
        PersonaStore.CurrentPersona = null;
        PersonaStore.Saved = false;
    }
}