class Cat {
     public Leg totalLeg;
     public void SetLeg(Leg x)
     {
         totalLeg = x;
     }
     public int GetTotalLeg()
     {
         return totalLeg.LegSize;
     }
 }
 class Leg
 {
     public int LegSize;
     public Nail totalNail;
     public Leg(Nail x)
     {
         totalNail = x;
         LegSize = 4;
     }
 }
class Nail 
{
     public int NailLength;
    public Nail()
    {
        NailLength = 4;
    }
}
static class Program
{
   static void Main()
    {
        Cat cotton = new Cat();
        Nail catNail = new Nail();
        Leg catLeg = new Leg(catNail);
        
        cotton.SetLeg(catLeg);
        
       cotton.totalLeg = catLeg;
        
        Console.WriteLine(cotton.GetTotalLeg());
        Console.WriteLine(cotton.totalLeg.totalNail.NailLength);
    }
}


// // TUPLE

// // static class Program
// // {
// //     static void Main()
// //     {
// //         const int x = 8;
// //         const int y = 10;

// //         (int , String) tuple = MyMethod(x, y);
// //         Console.WriteLine($"tuple.Item1 = {tuple.Item1}, tuple.Item2 = {tuple.Item2}");

// //     }

// //     static (int , String) MyMethod(int x, string y)
    
// //     {
// //         return (x, y);
// //     }



// // }

// // Not Tuple but same functionality

// class Cargo 
// {
// 	private Car _cargoCar;
// 	private Cycle _cargoCycle;
// 	private int _totalWeight;
// 	public Cargo(Car cargoCar, Cycle cargoCycle)
// 	{
// 		_cargoCar = cargoCar;
// 		_cargoCycle = cargoCycle;
// 		_totalWeight = 1000;
// 	}
// 	public int checkWeight() 
// 	{
// 		return _totalWeight;
// 	}
// 	public Car checkCar() 
// 	{
// 		return _cargoCar;
// 	}
// 	public Cycle checkCycle() 
// 	{
// 		return _cargoCycle;
// 	}
// }
// class Car
// {
// 	private string _carName;
// 	public Car(string brand) 
// 	{
// 		_carName = brand;
// 	}
// 	public string GetBrand() 
// 	{
// 		return _carName;
// 	}
// }
// class Cycle
// {
// 	private string _cycleName;
// 	public Cycle(string brand) 
// 	{
// 		_cycleName = brand;
// 	}
// 	public string GetBrand()
// 	{
// 		return _cycleName;
// 	}
// }

// static class Program
// {
// 	static void Main()
// 	{

// 		Cycle cycle = new Cycle("Polygon");
// 		Car car = new Car("Subaru");
// 		Cargo myCargo = new Cargo(car, cycle);

// 		int maxWeight = myCargo.checkWeight();
// 		Car myCar = myCargo.checkCar();
// 		Cycle myCycle = myCargo.checkCycle();

// 		Console.WriteLine(myCar.GetBrand());
// 		Console.WriteLine(myCycle.GetBrand());
//         Console.WriteLine(maxWeight);
// 	}
// }
