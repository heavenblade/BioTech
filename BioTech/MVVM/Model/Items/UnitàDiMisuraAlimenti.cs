using System.Collections.ObjectModel;

namespace BioTech.MVVM.Model.Items;

public class UnitàDiMisuraAlimenti : ObservableCollection<string>
{
    public UnitàDiMisuraAlimenti()
    {
        Add("100gr");
        Add("Unità");
    }
}