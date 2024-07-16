using System.Windows;
using System.Windows.Controls;
using BioTech.MVVM.Model.Stores;

namespace BioTech.MVVM.View.FitTest;

/// <summary>
///     Interaction logic for GuardaAllenamentoView.xaml
/// </summary>
public partial class FitTestConfronto : UserControl
{
    public FitTestConfronto()
    {
        InitializeComponent();

        PrepareContent();
    }

    private void PrepareContent()
    {
        PrecedenteFitTest.Text = FitTestStore.PreviousFitTest!.Data.ToShortDateString();
        CorrenteFitTest.Text = FitTestStore.CurrentFitTest!.Data.ToShortDateString();
        // dati corporei pre
        Peso_Pre.Text = FitTestStore.PreviousFitTest.Dati.Peso.ToString();
        BodyFat_Pre.Text = FitTestStore.PreviousFitTest.Dati.BodyFat.ToString();
        // dati corporei post
        Peso_Post.Text = FitTestStore.CurrentFitTest.Dati.Peso.ToString();
        BodyFat_Post.Text = FitTestStore.CurrentFitTest.Dati.BodyFat.ToString();
        // circonferenze pre
        Braccio_Pre.Text = FitTestStore.PreviousFitTest.Circonferenze.Braccio.ToString();
        Spalle_Pre.Text = FitTestStore.PreviousFitTest.Circonferenze.Spalle.ToString();
        ToraceC_Pre.Text = FitTestStore.PreviousFitTest.Circonferenze.Torace.ToString();
        Vita_Pre.Text = FitTestStore.PreviousFitTest.Circonferenze.Vita.ToString();
        Fianchi_Pre.Text = FitTestStore.PreviousFitTest.Circonferenze.Fianchi.ToString();
        Gamba_Pre.Text = FitTestStore.PreviousFitTest.Circonferenze.Gamba.ToString();
        // circonferenze pre
        Braccio_Post.Text = FitTestStore.CurrentFitTest.Circonferenze.Braccio.ToString();
        Spalle_Post.Text = FitTestStore.CurrentFitTest.Circonferenze.Spalle.ToString();
        ToraceC_Post.Text = FitTestStore.CurrentFitTest.Circonferenze.Torace.ToString();
        Vita_Post.Text = FitTestStore.CurrentFitTest.Circonferenze.Vita.ToString();
        Fianchi_Post.Text = FitTestStore.CurrentFitTest.Circonferenze.Fianchi.ToString();
        Gamba_Post.Text = FitTestStore.CurrentFitTest.Circonferenze.Gamba.ToString();
        // pliche pre
        Bicipite_Pre.Text = FitTestStore.PreviousFitTest.Pliche.Bicipite.ToString();
        Tricipite_Pre.Text = FitTestStore.PreviousFitTest.Pliche.Tricipite.ToString();
        ToraceP_Pre.Text = FitTestStore.PreviousFitTest.Pliche.Torace.ToString();
        Sottoscapola_Pre.Text = FitTestStore.PreviousFitTest.Pliche.Sottoscapola.ToString();
        Soprailio_Pre.Text = FitTestStore.PreviousFitTest.Pliche.Soprailio.ToString();
        Ombelico_Pre.Text = FitTestStore.PreviousFitTest.Pliche.Ombelico.ToString();
        Coscia_Pre.Text = FitTestStore.PreviousFitTest.Pliche.Coscia.ToString();
        CosciaEsterna_Pre.Text = FitTestStore.PreviousFitTest.Pliche.CosciaEsterna.ToString();
        // pliche post
        Bicipite_Post.Text = FitTestStore.CurrentFitTest.Pliche.Bicipite.ToString();
        Tricipite_Post.Text = FitTestStore.CurrentFitTest.Pliche.Tricipite.ToString();
        ToraceP_Post.Text = FitTestStore.CurrentFitTest.Pliche.Torace.ToString();
        Sottoscapola_Post.Text = FitTestStore.CurrentFitTest.Pliche.Sottoscapola.ToString();
        Soprailio_Post.Text = FitTestStore.CurrentFitTest.Pliche.Soprailio.ToString();
        Ombelico_Post.Text = FitTestStore.CurrentFitTest.Pliche.Ombelico.ToString();
        Coscia_Post.Text = FitTestStore.CurrentFitTest.Pliche.Coscia.ToString();
        CosciaEsterna_Post.Text = FitTestStore.CurrentFitTest.Pliche.CosciaEsterna.ToString();
    }

    private void CleanAndExit_Click(object sender, RoutedEventArgs e)
    {
        FitTestStore.CurrentFitTest = null;
        FitTestStore.Saved = false;
        PersonaStore.CurrentPersona = null;
        PersonaStore.Saved = false;
    }
}