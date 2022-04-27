namespace DesignPatterns.Factory;

public static class FactoryDemo
{
    public static void Execute()
    {
        Console.WriteLine($"------> {nameof(FactoryDemo)} <------");
        INotificationClientFactory notificationClientFactory = new NotificationFactory();
        using var emailClient = notificationClientFactory.CreateEmailNotification("Email client");
        emailClient.Execute();
        emailClient.LogClientState();
    }
}