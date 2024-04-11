
using System.Globalization;
using ContractProcessing.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter contract data");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine()!);
        Console.Write("Date (dd/MM/yyyy): ");
        DateTime date = DateTime.Parse(Console.ReadLine()!);
        Console.Write("Contract value: ");
        double totalValue = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Contract contract = new(number, date, totalValue);

        Console.Write("Enter number of installments: ");
        int n = int.Parse(Console.ReadLine()!);

        ContractService contractService = new(new PaypalService());
        contractService.ProcessContract(contract, n);

        Console.WriteLine("Installments:");
        foreach (Installment installment in contract.Installments) 
        {
            Console.WriteLine(installment);
        }
    }
}