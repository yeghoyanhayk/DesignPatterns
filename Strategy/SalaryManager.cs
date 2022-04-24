namespace DesignPatterns.Strategy;

public class ContractBaseSalaryCalculator : ISalaryCalculator
{
    public int Calculate(int amount)
    {
        Console.WriteLine($"Calculated in {nameof(ContractBaseSalaryCalculator)}");
        return amount;
    }
}

public class FullTimeSalaryCalculator : ISalaryCalculator
{
    public int Calculate(int amount)
    {
        Console.WriteLine($"Calculated in {nameof(FullTimeSalaryCalculator)}");
        return amount * 2;
    }
}

public class SalaryManager
{
    private int Salary { get; set; }

    private ISalaryCalculator SalaryCalculator { get; set; }

    public SalaryManager(ISalaryCalculator salaryCalculator)
    {
        SalaryCalculator = salaryCalculator;
    }

    public void SetCalculator(ISalaryCalculator salaryCalculator) => SalaryCalculator = salaryCalculator;

    public void SetSalary(int amount)
    {
        if (SalaryCalculator is null)
            throw new ArgumentNullException(nameof(SalaryCalculator));

        var salary = SalaryCalculator.Calculate(amount);
        Salary = salary;
        Console.WriteLine($"Salary is {Salary}");
    }
}