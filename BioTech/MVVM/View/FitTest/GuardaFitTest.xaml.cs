using System.Windows.Controls;
using BioTech.MVVM.Model.Stores;

namespace BioTech.MVVM.View.FitTest;

/// <summary>
///     Interaction logic for GuardaAllenamentoView.xaml
/// </summary>
public partial class GuardaFitTest : UserControl
{
    public GuardaFitTest()
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

        // pliche
        
        // muscoli

    }
}