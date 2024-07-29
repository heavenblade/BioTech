using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using BioTech.MVVM.Model.Stores;
using LiveCharts;
using LiveCharts.Wpf;

namespace BioTech.MVVM.View.Alimenti;

public partial class GuardaAlimentoView : UserControl
{
    public GuardaAlimentoView()
    {
        InitializeComponent();

        PrepareContent();

        PreparePieChart();
    }

    private void PrepareContent()
    {
        NomeAlimento.Text = AlimentoStore.CurrentAlimento!.Nome;
        UnitàDiMisura.Text = AlimentoStore.CurrentAlimento.UnitàDiMisura;
        Energia.Text = AlimentoStore.CurrentAlimento.Energia.ToString();
        GrassiInsaturi.Text = AlimentoStore.CurrentAlimento.GrassiInsaturi.ToString();
        GrassiSaturi.Text = AlimentoStore.CurrentAlimento.GrassiSaturi.ToString();
        Fibre.Text = AlimentoStore.CurrentAlimento.Fibre.ToString();
        Carboidrati.Text = AlimentoStore.CurrentAlimento.Carboidrati.ToString();
        Zuccheri.Text = AlimentoStore.CurrentAlimento.Zuccheri.ToString();
        Proteine.Text = AlimentoStore.CurrentAlimento.Proteine.ToString();
        Sale.Text = AlimentoStore.CurrentAlimento.Sale.ToString();
    }

    private void PreparePieChart()
    {
        GrassiSeries.Values = new ChartValues<double> { AlimentoStore.CurrentAlimento!.GrassiInsaturi };
        FibreSeries.Values = new ChartValues<double> { AlimentoStore.CurrentAlimento.Fibre };
        CarboidratiSeries.Values = new ChartValues<double> { AlimentoStore.CurrentAlimento.Carboidrati };
        ProteineSeries.Values = new ChartValues<double> { AlimentoStore.CurrentAlimento.Proteine };

        var customLegend = new DefaultLegend
        {
            BulletSize = 15,
            Foreground = Brushes.White,
            FontSize = 20
        };

        Chart.ChartLegend = customLegend;
    }

    private void StampaButton_Click(object sender, RoutedEventArgs e)
    {

    }
}