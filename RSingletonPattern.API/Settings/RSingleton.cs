using RDotNet;

namespace RSingletonPattern.API.Settings;

public static class RSingleton
{
    private static readonly REngine _engine = REngine.GetInstance();

    public static REngine GetInstance() =>
        _engine;
}
