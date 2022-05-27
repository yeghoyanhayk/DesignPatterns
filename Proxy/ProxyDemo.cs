namespace DesignPatterns.Proxy;

public static class ProxyDemo
{
    public static void Execute()
    {
        Console.WriteLine($"------> {nameof(ProxyDemo)} <------");

        
        var notificationSender = new NotificationServiceProxy();
        notificationSender.Notify("notify");
        notificationSender.NotifyToAll("notify all");
    }
}