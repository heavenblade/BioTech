namespace BioTech.MVVM.Model.Stores;

public static class PersonaStore
{
    private static Persona? _currentPersona;
    private static bool _saved;

    public static Persona? CurrentPersona
    {
        get => _currentPersona;
        set => _currentPersona = value;
    }

    public static bool Saved
    {
        get => _saved;
        set => _saved = value;
    }
}