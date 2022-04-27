namespace DesignPatterns.Strategy;

public static class StrategyDemo
{
    public static void Execute()
    {
        Console.WriteLine($"------> {nameof(StrategyDemo)} <------");

        var salaryManager = new SalaryManager(new FullTimeSalaryCalculator());

        salaryManager.SetSalary(1000000);
        
        salaryManager.SetCalculator(new ContractBaseSalaryCalculator());

        salaryManager.SetSalary(1000000);
    }
}