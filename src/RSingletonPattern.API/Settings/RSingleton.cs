using RDotNet;

namespace RSingletonPattern.API.Settings;

public static class RSingleton
{
    private static readonly object _lock = new();
    private static REngine? _engine;

    public static REngine GetInstance()
    {
        lock (_lock)
        {
            if (_engine is null)
            {
                _engine = REngine.GetInstance();
            }
        }

        return _engine;
    }
}
