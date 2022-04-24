namespace DesignPatterns.TemplateMethod;

public abstract class HiringManager
{
    protected abstract bool FirstStage();

    protected abstract bool SecondStage();

    public bool Process()
    {
        var isPassed = FirstStage();
        return isPassed && SecondStage();
    }
}

public class JuniorEngineerHiringManager : HiringManager
{
    protected override bool FirstStage()
    {
        Console.WriteLine("Easy test");
        return true;
    }

    protected override bool SecondStage()
    {
        Console.WriteLine("Easy interview");
        return true;
    }
}

public class SeniorEngineerHiringManager : HiringManager
{
    protected override bool FirstStage()
    {
        Console.WriteLine("Hard test");
        return true;
    }

    protected override bool SecondStage()
    {
        Console.WriteLine("Hard interview");
        return true;
    }
}