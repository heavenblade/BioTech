using System.Collections.ObjectModel;

namespace BioTech.MVVM.Model.Items;

public class TipologieAlimenti : ObservableCollection<string>
{
    public TipologieAlimenti()
    {
        Add("Proteina");
        Add("Verdura");
        Add("Carboidrato");
        Add("Frutta");
        Add("Frutta secca");
        Add("Dolce");
    }
}