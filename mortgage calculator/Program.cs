using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Mortgage Calculator (Bangladesh) ===");
        Console.Write("Enter loan amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter annual interest rate (in %): ");
        double annualRate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter loan period (in years): ");
        int years = Convert.ToInt32(Console.ReadLine());

        double monthlyRate = annualRate / 100 / 12;
        int totalMonths = years * 12;

        double monthlyPayment = principal * monthlyRate * Math.Pow(1 + monthlyRate, totalMonths) / (Math.Pow(1 + monthlyRate, totalMonths) - 1);
        double totalPaid = monthlyPayment * totalMonths;
        double totalInterest = totalPaid - principal;

        Console.WriteLine($"\nMonthly Payment: {monthlyPayment:0,0.00}৳");
        Console.WriteLine($"Total Paid: {totalPaid:0,0.00}৳");
        Console.WriteLine($"Total Interest: {totalInterest:0,0.00}৳");
    }
}
