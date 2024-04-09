using RDotNet;

namespace RSingletonPattern.API.Settings;

public sealed class RSingletonAlternate
{
    private static REngine? _engine;

    private RSingletonAlternate()
    {
        
    }

    public static REngine GetInstance()
    {
        if(_engine is null)
            _engine = REngine.GetInstance();

        return _engine;
    }
}
