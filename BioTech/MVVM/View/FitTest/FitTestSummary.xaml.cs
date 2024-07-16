using BioTech.MVVM.Model.Stores;
using System.Windows;
using System.Windows.Controls;
using BioTech.Core;

namespace BioTech.MVVM.View.FitTest;

/// <summary>
///     Interaction logic for GuardaAllenamentoView.xaml
/// </summary>
public partial class FitTestSummary : UserControl
{
    public FitTestSummary()
    {
        InitializeComponent();

        PrepareContent();
    }

    private void PrepareContent()
    {
        NomeCognome.Text = FitTestStore.CurrentFitTest!.Nome + " " + FitTestStore.CurrentFitTest.Cognome;
        Data.Text = FitTestStore.CurrentFitTest.Data.ToShortDateString();
        // dati corporei
        Altezza.Text = FitTestStore.CurrentFitTest.Dati.Altezza.ToString();
        Peso.Text = FitTestStore.CurrentFitTest.Dati.Peso.ToString();
        BodyFat.Text = FitTestStore.CurrentFitTest.Dati.BodyFat.ToString();
        // ossa
        Polso.Text = FitTestStore.CurrentFitTest.Ossa.Polso.ToString();
        Ginocchio.Text = FitTestStore.CurrentFitTest.Ossa.Ginocchio.ToString();
        Caviglia.Text = FitTestStore.CurrentFitTest.Ossa.Caviglia.ToString();
        // pliche
        Bicipite.Text = FitTestStore.CurrentFitTest.Pliche.Bicipite.ToString();
        Tricipite.Text = FitTestStore.CurrentFitTest.Pliche.Tricipite.ToString();
        ToraceP.Text = FitTestStore.CurrentFitTest.Pliche.Torace.ToString();
        Sottoscapola.Text = FitTestStore.CurrentFitTest.Pliche.Sottoscapola.ToString();
        Soprailio.Text = FitTestStore.CurrentFitTest.Pliche.Soprailio.ToString();
        Ombelico.Text = FitTestStore.CurrentFitTest.Pliche.Ombelico.ToString();
        Coscia.Text = FitTestStore.CurrentFitTest.Pliche.Coscia.ToString();
        CosciaEsterna.Text = FitTestStore.CurrentFitTest.Pliche.CosciaEsterna.ToString();
        // muscoli
        Braccio.Text = FitTestStore.CurrentFitTest.Circonferenze.Braccio.ToString();
        Spalle.Text = FitTestStore.CurrentFitTest.Circonferenze.Spalle.ToString();
        ToraceC.Text = FitTestStore.CurrentFitTest.Circonferenze.Torace.ToString();
        Vita.Text = FitTestStore.CurrentFitTest.Circonferenze.Vita.ToString();
        Fianchi.Text = FitTestStore.CurrentFitTest.Circonferenze.Fianchi.ToString();
        Gamba.Text = FitTestStore.CurrentFitTest.Circonferenze.Gamba.ToString();
    }

    private void CleanAndExit_Click(object sender, RoutedEventArgs e)
    {
        FitTestStore.CurrentFitTest = null;
        FitTestStore.Saved = false;
        PersonaStore.CurrentPersona = null;
        PersonaStore.Saved = false;
    }

    private void Stampa_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Confronta_Click(object sender, RoutedEventArgs e)
    {
        var fitTestList = MongoDbClient.GetAllFitTestOfPerson(PersonaStore.CurrentPersona!.RefId);
        
        FitTestStore.PreviousFitTest = fitTestList.Where(x => x.Data < FitTestStore.CurrentFitTest!.Data).MaxBy(x => x.Data);
    }
}