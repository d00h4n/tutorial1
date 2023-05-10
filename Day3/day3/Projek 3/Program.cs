class Parrent 
{
    public string myString;
    public Parrent(string x)
    {
        myString = "Parrent ";
    }
    public void MymethodParrent(){
        Console.WriteLine("Parrent.MymethodParrent");
    }
}

class Child : Parrent
{
	public string? myStringx;
	public Child(string y) : base (y)
	{
		myString = y;
	}
	public void MyMethodChild()
	{
		Console.WriteLine("Child.MyMethodChild");
	}
}


// class Vehicle   
// {
//   public string brand = "Honda";  
//   public void merek()             
//   {                    
//     Console.WriteLine("Supra");
//   }
// }

// class Car : Vehicle 
// {
//   public string modelName = "2012";  
//   }

// class Program
// {
//   static void Main(string[] args)
//   {
   
//     Car myCar = new Car();

//     myCar.merek();

//     Console.WriteLine(myCar.brand + " " + myCar.modelName);
//   }
// }

