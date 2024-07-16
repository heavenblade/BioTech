using System.Windows;
using System.Windows.Controls;
using BioTech.Core;
using BioTech.MVVM.Model;
using BioTech.MVVM.Model.Stores;
using Microsoft.VisualBasic;

namespace BioTech.MVVM.View.Allenamenti;

/// <summary>
///     Interaction logic for GuardaAllenamentoView.xaml
/// </summary>
public partial class ModificaTabellaView : UserControl
{
    public ModificaTabellaView()
    {
        InitializeComponent();

        PrepareContent();
    }

    private void PrepareContent()
    {
        Allenamento allenamento = AllenamentoStore.CurrentAllenamento;

        if (allenamento == null)
            return;

        NomeTabella.Text = allenamento.Nome;
        CategoriaTabella.Text = allenamento.Categoria;
        ContenutoTabella.Text = allenamento.Tabella;
    }

    private void CleanAndExit_Click(object sender, RoutedEventArgs e)
    {
        AllenamentoStore.CurrentAllenamento = null;
    }

    private void RinominaTabella_OnClick(object sender, RoutedEventArgs e)
    {
        string newName = Interaction.InputBox("Inserire il nuovo nome per la tabella selezionata:", "Rinomina");

        MongoDbClient.RenameAllenamento(NomeTabella.Text, newName);

        NomeTabella.Text = newName;
    }

    private void StampaButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void SalvaButton_Click(object sender, RoutedEventArgs e)
    {
        string nome = NomeTabella.Text;
        string categoria = CategoriaTabella.Text;
        string tabella = ContenutoTabella.Text;

        MongoDbClient.UpdateAllenamento(nome, categoria, tabella);

        MessageBox.Show("Tabella salvata con successo nel database!");
    }
}