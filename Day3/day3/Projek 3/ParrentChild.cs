namespace Program.cs
{
   class Program {
	static void Main(string[] args) {
        
		Parrent parent = new Parrent("k");
		Child child = new Child("n");

		Console.WriteLine(parent.myString);
		Console.WriteLine(child.myString);
		parent.MymethodParrent();
		child.MymethodParrent();
		child.MyMethodChild();
        
        
	}
} 
}