namespace DesignPatterns.Singleton;

//Eager initialization of singleton
public class SingletonEager
{
    private static SingletonEager instance = new SingletonEager();

    private SingletonEager()
    {
    }

    public static SingletonEager GetInstance => instance;
}

////lazy initialization of singleton
public class SingletonLazy
{
    private static SingletonLazy? _instance = null;

    private SingletonLazy()
    {
    }

    public static SingletonLazy? GetInstance
    {
        get { return _instance ??= new SingletonLazy(); }
    }
}

////Thread-safe initialization of singleton
public class SingletonThreadSafe
{
    private static SingletonThreadSafe? _instance = null;

    private SingletonThreadSafe()
    {
    }

    private static readonly object LockThis = new();

    public static SingletonThreadSafe? GetInstance
    {
        get
        {
            lock (LockThis)
            {
                return _instance ??= new SingletonThreadSafe();
            }
        }
    }
}