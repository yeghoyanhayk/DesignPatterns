namespace DesignPatterns.Factory;

public abstract class NotificationClient : IDisposable
{
    private readonly string _clientName;
    private bool _isDisposed = default;
    private readonly HttpClient _client;

    protected NotificationClient(string clientName)
    {
        _clientName = clientName;
        _client = new HttpClient();
    }

    public abstract void Execute();

    public void LogClientState() => Console.WriteLine($"{_clientName} is alive.");

    public void Dispose()
    {
        if (_isDisposed) return;

        _client.Dispose();
    }
}

public class SmsNotificationClient : NotificationClient
{
    public override void Execute() => Console.WriteLine($"Executed from {nameof(SmsNotificationClient)}");

    public SmsNotificationClient(string clientName) : base(clientName)
    {
    }
}

public class EmailNotificationClient : NotificationClient
{
    public override void Execute() => Console.WriteLine($"Executed from {nameof(EmailNotificationClient)}");

    public EmailNotificationClient(string clientName) : base(clientName)
    {
    }
}

public class NotificationFactory : INotificationClientFactory
{
    public NotificationClient CreateEmailNotification(string clientName) => new EmailNotificationClient(clientName);

    public NotificationClient CreateSmsNotification(string clientName) => new SmsNotificationClient(clientName);
}

public interface INotificationClientFactory
{
    NotificationClient CreateEmailNotification(string clientName);
    NotificationClient CreateSmsNotification(string clientName);
}