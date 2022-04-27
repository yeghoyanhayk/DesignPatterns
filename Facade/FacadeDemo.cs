namespace DesignPatterns.Facade;

public static class FacadeDemo
{
    public static void Execute()
    {
        Console.WriteLine($"------> {nameof(FacadeDemo)} <------");
        
        // Evaluate mortgage eligibility for customer
        var customer = new Customer("John Doe");

        var mortgage = new Mortgage();
        var eligible = mortgage.IsEligible(customer, 125000);

        Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approved" : "Rejected"));
    }
}