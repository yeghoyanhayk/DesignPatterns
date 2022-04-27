namespace DesignPatterns.TemplateMethod;

public static class TemplateMethodDemo
{
    public static void Execute()
    {
        Console.WriteLine($"------> {nameof(TemplateMethodDemo)} <------");

        var seniorEngineerHiringManager = new SeniorEngineerHiringManager();
        var juniorEngineerHiringManager = new JuniorEngineerHiringManager();

        seniorEngineerHiringManager.Process();
        juniorEngineerHiringManager.Process();
    }
}