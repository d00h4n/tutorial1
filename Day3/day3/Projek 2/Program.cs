class Vehicle   
{
  public string brand = "Honda";  
  public void merek()             
  {                    
    Console.WriteLine("Supra");
  }
}

class Car : Vehicle 
{
  public string modelName = "2012";  
  }

class Program3
{
  static void Main(string[] args)
  {
   
    Car myCar = new Car();

    myCar.merek();

    Console.WriteLine(myCar.brand + " " + myCar.modelName);
  }
}

