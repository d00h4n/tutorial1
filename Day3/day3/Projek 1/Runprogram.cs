// using coba1; // Bakal ambil ke Child
using coba2;
using coba3;    // Bakal ambil ke Parent
class Program1
{
  static void Main(string[] args) 
  {
    // Console.WriteLine("How Many Roles you want to create?");
    // int n = int.Parse(Console.ReadLine());
    Role myrole = new Role ();  
    Role myrolef = new Attact();  
    Role myrolem = new Middle();  
    Role myroleb = new Back();

    myrole.roles();
    myrolef.roles();
    myrolem.roles();
    myroleb.roles();

    Calculate c = new Calculate();
    c.AddNumbers(1, 2);
    c.AddNumbers(1, 2, 3);
    Console.WriteLine("\nPress Enter Key to Exit..");
    Console.ReadLine();
 
  }
}


