namespace BioTech.MVVM.Model.Stores;

public static class PersonaStore
{
    private static Persona? _currentPersona;

    public static Persona? CurrentPersona
    {
        get => _currentPersona;
        set => _currentPersona = value;
    }
}