// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Please enter a number to divide : \n");

//         try
//         {
//             int num1 = int.Parse(Console.ReadLine());
//             int num2 = int.Parse(Console.ReadLine());

//             int result = num1 / num2;

//             Console.WriteLine(result);

//         }
//         catch(DivideByZeroException )
//         {
//             Console.Write("Cannot divide by zero. Please try again.");
//         }
//         catch(Exception )
//         {
//             Console.Write("Error occurred! Please try again.");
//         }
//     }

// }

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account("Luna Lauriel ", 20000);
            Console.WriteLine("Uang Anda = " + account.Balance);
            Console.WriteLine("Masukan Pecahan Uang yang ingin di keluarkan!");
            int money = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukan Jumlah uang yang ingin di keluarkan!");
            int x = int.Parse(Console.ReadLine());
            try
            {
                for (int i = 0; i < x; i++)
                {
                    var amount = money;
                    account.Withdraw(amount);
                    Console.WriteLine("Withdrawn {0} from {1}'s account. \n", amount, account.Name);
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Operasional Gagal !!!");
                Console.WriteLine(ex.Message);
            }
        }
    }
    class Account
    {

        public string Name { get; private set; }
        public int Balance { get; private set; }

        public Account(string name, int balance)
        {
            Name = name;
            Balance = balance;
        }
        public void Withdraw(int amount)
        {
            if (amount > Balance)
                throw new InvalidOperationException("Tabungan tidak cukup");

            Console.WriteLine("Withdrawing {0} from the {1}'s account", amount, Name);
            Balance = Balance - amount;
            Console.WriteLine($"Transaction completed. Account Balance is {Balance}");

        }
    }
}
