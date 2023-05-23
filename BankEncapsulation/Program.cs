namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.Write("Enter the amount to deposit: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            account.Deposit(depositAmount);

            double currentBalance = account.GetBalance();

            Console.WriteLine("Current Balance: " + currentBalance);
        }
        
    }
}
