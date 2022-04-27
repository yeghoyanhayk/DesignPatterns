namespace DesignPatterns.Facade;

public class Bank
{
    public bool HasSufficientSavings(Customer c, int amount)
    {
        Console.WriteLine("Check bank for " + c.Name);
        return true;
    }
}

public class Credit
{
    public bool HasGoodCredit(Customer c)
    {
        Console.WriteLine("Check credit for " + c.Name);
        return true;
    }
}

public class Loan
{
    public bool HasNoBadLoans(Customer c)
    {
        Console.WriteLine("Check loans for " + c.Name);
        return true;
    }
}

public class Customer
{
    private readonly string _name;
    public Customer(string name)
    {
        _name = name;
    }

    public string Name
    {
        get { return _name; }
    }
}

public class Mortgage
{
    private readonly Bank _bank = new();
    private readonly Loan _loan = new();
    private readonly Credit _credit = new();

    public bool IsEligible(Customer customer, int amount)
    {
        Console.WriteLine("{0} applies for {1:C} loan\n", customer.Name, amount);

        var eligible = true;
        if (!_bank.HasSufficientSavings(customer, amount))
        {
            eligible = false;
        }
        else if (!_loan.HasNoBadLoans(customer))
        {
            eligible = false;
        }
        else if (!_credit.HasGoodCredit(customer))
        {
            eligible = false;
        }

        return eligible;
    }
}