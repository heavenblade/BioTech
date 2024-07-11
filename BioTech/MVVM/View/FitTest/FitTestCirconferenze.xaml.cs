using BioTech.MVVM.Model;
using BioTech.MVVM.Model.Stores;
using System.Windows;
using System.Windows.Controls;
using BioTech.Core;

namespace BioTech.MVVM.View.FitTest;

/// <summary>
///     Interaction logic for GuardaAllenamentoView.xaml
/// </summary>
public partial class FitTestCirconferenze : UserControl
{
    public FitTestCirconferenze()
    {
        InitializeComponent();

        PrepareContent();
    }

    private void PrepareContent()
    {
        var fitTest = FitTestStore.CurrentFitTest;

        if (fitTest?.Circonferenze == null)
            return;

        Braccio.Text = fitTest.Circonferenze.Braccio.ToString();
        Spalle.Text = fitTest.Circonferenze.Spalle.ToString();
        Torace.Text = fitTest.Circonferenze.Torace.ToString();
        Vita.Text = fitTest.Circonferenze.Vita.ToString();
        Fianchi.Text = fitTest.Circonferenze.Fianchi.ToString();
        Gamba.Text = fitTest.Circonferenze.Gamba.ToString();
    }

    private void Finalizza_Click(object sender, RoutedEventArgs e)
    {
        Circonferenze circonferenze = new()
        {
            Braccio = double.Parse(Braccio.Text),
            Spalle = double.Parse(Spalle.Text),
            Torace = double.Parse(Torace.Text),
            Vita = double.Parse(Vita.Text),
            Fianchi = double.Parse(Fianchi.Text),
            Gamba = double.Parse(Gamba.Text)
        };

        FitTestStore.CurrentFitTest!.Circonferenze = circonferenze;

        if (FitTestStore.Saved)
        {
            MongoDbClient.UpdateFitTest(FitTestStore.CurrentFitTest);
        }
        else
        {
            MongoDbClient.InsertFitTest(FitTestStore.CurrentFitTest);
            FitTestStore.Saved = true;
        }

        if (PersonaStore.Saved) 
            return;

        MongoDbClient.InsertNuovaPersona(PersonaStore.CurrentPersona!);
        PersonaStore.Saved = true;
    }

    private void CleanAndExit_Click(object sender, RoutedEventArgs e)
    {
        FitTestStore.CurrentFitTest = null;
        FitTestStore.Saved = false;
        PersonaStore.CurrentPersona = null;
        PersonaStore.Saved = false;
    }
}