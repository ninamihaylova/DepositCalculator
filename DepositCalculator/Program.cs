class DepositCalculator
{
    static void Main(string[] args)

    {
        decimal depositAmount = decimal.Parse(Console.ReadLine());
      int depositMonths = int.Parse(Console.ReadLine());

        decimal annualInterestRate = decimal.Parse(Console.ReadLine());

        decimal annualInterest = depositAmount * annualInterestRate/100;

        decimal monthInterest = annualInterest/12;
        decimal totalAmount = depositAmount + monthInterest*depositMonths;
        
        Console.WriteLine(totalAmount);
    }
    }