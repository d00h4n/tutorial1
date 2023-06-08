using System;
using System.IO;

// class Program
// {
//     static void Main(string[] args)
//     {
//         using (var account = new Account("Luna Lauriel ", 20000))
//         {
//             Console.WriteLine("Uang Anda = " + account.Balance);
//             Console.WriteLine("Masukan Pecahan Uang yang ingin di keluarkan!");
//             int money = int.Parse(Console.ReadLine());
//             Console.WriteLine("Masukan Jumlah uang yang ingin di keluarkan!");
//             int x = int.Parse(Console.ReadLine());
//             try
//             {
//                 for (int i = 0; i < x; i++)
//                 {
//                     var amount = money;
//                     account.Withdraw(amount);
//                     Console.WriteLine("Withdrawn {0} from {1}'s account. \n", amount, account.Name);
//                 }
//             }
//             catch (InvalidOperationException ex)
//             {
//                 Console.WriteLine("Operasional Gagal !!!");
//                 Console.WriteLine(ex.Message);
//             }
//         }
//     }
// }

// class Account : IDisposable
// {
//     private FileStream fileStream;

//     public string Name { get; private set; }
//     public int Balance { get; private set; }

//     public Account(string name, int balance)
//     {
//         Name = name;
//         Balance = balance;
//         fileStream = new FileStream("logfile.txt", FileMode.Create);
//     }

//     public void Withdraw(int amount)
//     {
//         if (amount > Balance)
//             throw new InvalidOperationException("Tabungan tidak cukup");

//         Console.WriteLine("Withdrawing {0} from {1}'s account", amount, Name);
//         Balance = Balance - amount;
//         Console.WriteLine($"Transaction completed. Account Balance is {Balance}");
//     }

//     public void Dispose()
//     {
//         // Clean up any unmanaged resources here
//         if (fileStream != null)
//         {
//             fileStream.Close();
//             fileStream.Dispose();
//         }
// 		Console.ReadKey();
//     }
// }

class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            using (var resource = new UnmanagedResource())
            {
                Console.WriteLine($"Using Resources {i + 1}");
            }
            Console.WriteLine();
        }

        // Force garbage collection to show destruction of objects
        Console.WriteLine("Forcing Garbage Collection");
        GC.Collect();
        GC.WaitForPendingFinalizers();
        Console.WriteLine("Garbage Collection Complete");
    }
}
