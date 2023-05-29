// class Program
// {
// 	public static void Main(string[] args)
// 	{
// 		Random random = new Random();
// 		Dictionary<string, int> dictionary = new Dictionary<string, int>();

// 		dictionary.Add("a", 1);
// 		dictionary.Add("b", 2);
// 		dictionary.Add("c", 3);
// 		dictionary.Add("d", 4);
// 		dictionary.Add("e", 5);

// 		for (int i = 0; i < 10; ++i)
// 		{
// 			int index = random.Next(dictionary.Count);

// 			//string key = dictionary.Keys.ElementAt(index);
// 			//int value = dictionary.Values.ElementAt(index);
// 			KeyValuePair<string, int> pair = dictionary.ElementAt(index);

// 			Console.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
// 		}
// 	}
// }

// using System;
// using System.Collections;
	
// public class Program
// {
// 	public static void Main()
// 	{
// 		Hashtable numberNames = new Hashtable();
// 		numberNames.Add(1,"One"); //adding a key/value using the Add() method
// 		numberNames.Add(2,"Two");
// 		numberNames.Add(3,"Three");

// 		//The following throws run-time exception: key already added.
// 		//numberNames.Add(3, "Three"); 

// 		foreach(DictionaryEntry kvp in numberNames)
// 			Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

// 		//creating a dictionary using collection-initializer syntax
// 		var cities = new Hashtable(){
// 			{"UK", "London, Manchester, Birmingham"},
// 			{"USA", "Chicago, New York, Washington"},
// 			{"India", "Mumbai, New Delhi, Pune"}
// 		};

// 		foreach(DictionaryEntry kvp in cities)
// 			Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);		

// 	}
// }





class Program {
  
    // Driver code
    public static void Main()
    {
        string name1 , name2, nameR;
  
        // Create a new dictionary of 
        // strings, with string keys.
        Dictionary<string, string> myDict = 
        new Dictionary<string, string>();
        
        // Adding key/value pairs in myDict
        myDict.Add("Lucia", "Attack");
        myDict.Add("Crome", "Tank");
        myDict.Add("Wanshi", "Support");
        myDict.Add("21", "Tank");
        myDict.Add("Liv", "Amplifier");
        myDict.Add("Noctis", "Attack");
        name1 = Console.ReadLine();
        name2 = Console.ReadLine();
        nameR = Console.ReadLine();

        
        Console.WriteLine("Insert New Name: ");
        bool added = myDict.TryAdd(name1, name2);
		Console.WriteLine("\nTrying to add a new key-value pair for "+name1+" : " + added);
        Console.WriteLine("New Name: ");


        foreach (KeyValuePair<string, string> KVP in myDict)
        {
            Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
        }
        
        Console.WriteLine("Delete: ");
        myDict.Remove(nameR);
			Console.WriteLine("\nDictionary after removing key-value pair for "+ nameR +":");
			foreach (KeyValuePair<string, string> KVP in myDict)
			{
				Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}",KVP.Key,KVP.Value);
			}
    }
}

