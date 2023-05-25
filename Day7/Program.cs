namespace Delegates
{
    public class Operation
    {
        public static void Penjumlahan(int a)
        {
            Console.WriteLine("Tambah={0}", a + a);
        }
        public static void Pengurangan(int a)
        {
            Console.WriteLine("Kurang={0}", a - a);
        }
        public static void Perkalian(int a)
        {
            Console.WriteLine("Kali={0}",a * a);
        }
        public static void Bagi(int a)
        {
            Console.WriteLine("Bagi={0}",a / a);
        }

        public static void Prima (int a)
        {
            
        }
    }
    class Program
    {
        delegate void DelOp(int x);

        static void Main(string[] args)
        {
            // Delegate instantiation
            DelOp obj = Operation.Penjumlahan;
            obj += Operation.Pengurangan;
            obj += Operation.Perkalian;
            obj += Operation.Bagi;

            obj(4);
            obj(8);

            Console.ReadLine();
        }
    }

public delegate void PInventory();

class Program {
    static void Main(string[] args) {
        PInventory equipment1 = new PInventory(Use.eq1);
        PInventory equipment2 = new PInventory(Use.eq2);
        PInventory equipment3 = new PInventory(Use.eq3);
        PInventory equipment4 = new PInventory(Use.eq4);
        PInventory equipment5 = new PInventory(Use.eq5);
        PInventory equipment6 = new PInventory(Use.eq6);
        string retry = "Done";
        Console.WriteLine("Use 1-6 your equipment:");
        do{

        
        char input = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (input++) {
            case '1':
                PerformAction(equipment1);
                break;
            case '2':
                PerformAction(equipment2);
                break;
            case '3':
                PerformAction(equipment3);
                break;
            case '4':
                PerformAction(equipment4);
                break;
            case '5':
                PerformAction(equipment5);
                break;
            case '6':
                PerformAction(equipment6);
                break;
            default:
                Console.WriteLine("Not in the list");
                Console.WriteLine("Would you like to retry?");
                retry = Console.ReadLine();
                break;
            
        }
        }
        while  (retry != "No");
        
        
    }

    static void PerformAction(PInventory Use) {
        Use.Invoke();
    }
}


public class Use {
    // Player action methods
    public static void eq1() {
        Console.WriteLine("Switch to Rifle.");
    }

    public static void eq2() {
        Console.WriteLine("Switch to HandGun");
    }

    public static void eq3() {
        Console.WriteLine("Switch to Brick");
    }
    public static void eq4() {
        Console.WriteLine("Switch to Coin");
    }
    public static void eq5() {
        Console.WriteLine("Switch to Syringe");
    }
    public static void eq6() {
        Console.WriteLine("Switch to hands");
    }
}

public class Publisher
{
    // B1_Event untuk mengirim pesan ke subscriber
    public event EventHandler<string> MessageSent;

    public void SendMessage(string message)
    {
        // Memanggil semua metode yang terdaftar pada event
        MessageSent?.Invoke(this, message);
    }
}

public class Subscriber
{
    public void OnMessageReceived(object sender, string message)
    {   

        Console.WriteLine($"Subscriber menerima pesan: {message}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber1 = new Subscriber();
        Subscriber subscriber2 = new Subscriber();
        Subscriber subscriber3 = new Subscriber();


        // Mendaftarkan metode subscriber ke event
        publisher.MessageSent += subscriber1.OnMessageReceived;
        publisher.MessageSent += subscriber2.OnMessageReceived;


        publisher.SendMessage("Halo, ini pesan untuk semua subscriber!");
    }
}

}