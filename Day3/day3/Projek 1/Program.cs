class Role  // Base class (parent) 
{
  public virtual void roles() 
  {
    Console.WriteLine("Available : ");
  }
}

class Attact : Role  // Derived class (child) 
{
  public override void roles() 
  {
    Console.WriteLine("Frontline");
  }
}

class Middle : Role   
{
  public override void roles() 
  {
    Console.WriteLine("Middlefield");
  }
}

class Back : Role{
    public override void roles() 
    {
        Console.WriteLine("Deffender");
    }
}

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
  }
}