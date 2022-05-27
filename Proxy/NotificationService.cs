namespace DesignPatterns.Proxy;
public class NotificationService : INotificationService
{
    public void Notify(string message)
    {
        Console.WriteLine(message);
    }

    public void NotifyToAll(string message)
    {
        Console.WriteLine(message);
    }
}

// provided by 3-rd party interface
public interface INotificationService
{
    void Notify(string message);
    void NotifyToAll(string message);
}

public class NotificationServiceProxy : INotificationService
{
    private readonly INotificationService _notificationService;

    public NotificationServiceProxy()
    {
        _notificationService = new NotificationService();
    }

    public void Notify(string message)
    {
        // log something
        _notificationService.Notify(message + " from proxy");
    }

    public void NotifyToAll(string message)
    {
        // log something
        _notificationService.NotifyToAll(message + " from proxy");
    }
}