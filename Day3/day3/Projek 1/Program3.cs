namespace coba3
{
  
class Role  // Base class (parent) 
{
  public virtual void roles() 
  {
    Console.WriteLine("Available Roles: ");
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
    public new void roles() 
    {
        Console.WriteLine("Deffender");
    }
}
}