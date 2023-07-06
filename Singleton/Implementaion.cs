namespace Singleton;

public class Logger
{
    /// <summary>
    /// Using Lazy<T> for thread safety
    /// </summary>
    private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());

    protected Logger() { }

    public static Logger Instance
    {
        get { return _instance.Value; }
    }

    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}
