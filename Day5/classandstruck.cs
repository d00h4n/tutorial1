// // Class Declaration
// public class Author {

// 	// Data members of class
// 	public string name;
// 	public string language;
// 	public int article_no;
// 	public int improv_no;

// 	// Method of class
// 	public void Details(string name, string language, int article_no, int improv_no)
// 	{
// 		this.name = name;
// 		this.language = language;
// 		this.article_no = article_no;
// 		this.improv_no = improv_no;

// 		Console.WriteLine("The name of the author is : " + name
// 						+ "\nThe name of language is : " + language
// 						+ "\nTotal number of article published "
// 						+ article_no + "\nTotal number of Improvements:"
// 						+" done by author is : " + improv_no);
// 	}

// 	// Main Method
// 	public static void Main(String[] args)
// 	{

// 		// Creating object
// 		Author obj = new Author();

// 		// Calling method of class
// 		// using class object
// 		obj.Details("Ankita", "C#", 80, 50);
// 	}
// }



// // Defining structure
// public struct Car
// {

// 	// Declaring different data types
// 	public string Brand;
// 	public string Model;
// 	public string Color;
// }

// class GFG {

// 	// Main Method
// 	static void Main(string[] args)
// 	{

// 		// Declare c1 of type Car
// 		// no need to create an
// 		// instance using 'new' keyword
// 		Car c1;

// 		// c1's data
// 		c1.Brand = "Bugatti";
// 		c1.Model = "Bugatti Veyron EB 16.4";
// 		c1.Color = "Gray";

// 		// Displaying the values
// 		Console.WriteLine("Name of brand: " + c1.Brand
// 						+ "\nModel name: " + c1.Model
// 						+ "\nColor of car: " + c1.Color);
// 	}
// }


class Automobile {
    public string AutomobilePrint () {
        return "AutomobilePrint";
    }
}

class Car : Automobile {
    public string CarPrint () {
        return "CarPrint";
    }
}

static class Program {
    static void Main () {
        int a = 2;
        long b = a; //Upcast
        Console.WriteLine(b);

        long c = 3;
        int d = (int) c; //Downcast
        Console.WriteLine(d);

        //Class Upcast and Downcast
        Car car = new();
        Automobile automobile = car;
        Console.WriteLine (automobile.AutomobilePrint());
        //Console.WriteLine (automobile.CarPrint ());
        Console.WriteLine (car.CarPrint());

        Automobile automobile2 = new();
        Car car2 = (Car) automobile2;
        Console.WriteLine (automobile.AutomobilePrint());
        Console.WriteLine (car2.CarPrint ());
    }
}