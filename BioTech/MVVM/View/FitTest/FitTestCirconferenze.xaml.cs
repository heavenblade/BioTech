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
        Polso.Text = fitTest.Ossa.Polso.ToString();
        Ginocchio.Text = fitTest.Ossa.Ginocchio.ToString();
        Caviglia.Text = fitTest.Ossa.Caviglia.ToString();
    }

    private void Finalizza_Click(object sender, RoutedEventArgs e)
    {
        FitTestStore.CurrentFitTest!.Circonferenze = new()
        {
            Braccio = double.Parse(Braccio.Text),
            Spalle = double.Parse(Spalle.Text),
            Torace = double.Parse(Torace.Text),
            Vita = double.Parse(Vita.Text),
            Fianchi = double.Parse(Fianchi.Text),
            Gamba = double.Parse(Gamba.Text)
        };
        
        FitTestStore.CurrentFitTest.Ossa = new()
        {
            Polso = double.Parse(Polso.Text),
            Ginocchio = double.Parse(Ginocchio.Text),
            Caviglia = double.Parse(Caviglia.Text)
        };

        FitTestStore.CurrentFitTest.Dati = new()
        {
            Altezza = PersonaStore.CurrentPersona!.Altezza,
            Peso = PersonaStore.CurrentPersona.Peso,
            BodyFat = Math.Round(ComputeBodyFatPercentage(), 1)
        };

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

        MongoDbClient.InsertNuovaPersona(PersonaStore.CurrentPersona);
        PersonaStore.Saved = true;
    }

    private void CleanAndExit_Click(object sender, RoutedEventArgs e)
    {
        FitTestStore.CurrentFitTest = null;
        FitTestStore.Saved = false;
        PersonaStore.CurrentPersona = null;
        PersonaStore.Saved = false;
    }

    private void OnTextChanged(object sender, RoutedEventArgs e)
    {
        if (!Braccio.Text.Equals("") &&
            !Spalle.Text.Equals("") &&
            !Torace.Text.Equals("") &&
            !Vita.Text.Equals("") &&
            !Fianchi.Text.Equals("") &&
            !Gamba.Text.Equals("") &&
            !Polso.Text.Equals("") &&
            !Ginocchio.Text.Equals("") &&
            !Caviglia.Text.Equals(""))
        {
            FinalizzaButton.IsEnabled = true;
        }
        else
        {
            FinalizzaButton.IsEnabled = false;
        }
    }

    private static double ComputeBodyFatPercentage() => 
        PersonaStore.CurrentPersona!.Sesso!.Equals("Maschio") ? JacksonPollockM() : JacksonPollockF();

    private static double JacksonPollockM()
    {
        double densità = 1.112 - 0.00043499 * SumPliche() + 0.00000055 * Math.Pow(SumPliche(), 2) - 0.00028826 * Età();
        return 495/densità - 450;
    }

    private static double JacksonPollockF()
    {
        double densità = 1.097 - 0.00046971 * SumPliche() + 0.00000056 * Math.Pow(SumPliche(), 2) - 0.00012828 * Età();
        return 495/densità - 450;
    }

    private static double SumPliche()
    {
        return FitTestStore.CurrentFitTest!.Pliche.Bicipite +
            FitTestStore.CurrentFitTest.Pliche.Tricipite +
            FitTestStore.CurrentFitTest.Pliche.Torace +
            FitTestStore.CurrentFitTest.Pliche.Sottoscapola +
            FitTestStore.CurrentFitTest.Pliche.Soprailio +
            FitTestStore.CurrentFitTest.Pliche.Ombelico +
            FitTestStore.CurrentFitTest.Pliche.Coscia +
            FitTestStore.CurrentFitTest.Pliche.CosciaEsterna;
    }

    private static int Età()
    {
        DateTime now = DateTime.Now;
        DateTime dataNascita = DateTime.Parse(PersonaStore.CurrentPersona!.DataNascita!);
        int age = DateTime.Now.Year - dataNascita.Year;

        if (now.Month < dataNascita.Month || (now.Month == dataNascita.Month && now.Day < dataNascita.Day))
            age--;

        return age;
    }
}