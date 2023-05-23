
// public class ToyBox<T> {
//     private T toy;
//     public void AddToy(T newToy) {
//         toy = newToy;
//     }

//     public T GetToy() {
//         return toy;
//     }
// }

// class Program {
//     static void Main(string[] args) {
//         ToyBox<string> dollBox = new ToyBox<string>();
//         dollBox.AddToy("Barbie");
//         Console.WriteLine("Mainan dalam dollBox: " + dollBox.GetToy());

//         ToyBox<string> carBox = new ToyBox<string>();
//         carBox.AddToy("Hot Wheels");
//         Console.WriteLine("Mainan carBox: " + carBox.GetToy());

//         ToyBox<int> totalToy = new ToyBox<int>();
//         totalToy.AddToy(5);
//         Console.WriteLine("Jumlah mainan" + totalToy.GetToy());

//         ToyBox<bool> anyToy = new ToyBox<bool>();
//         anyToy.AddToy(false);
//         Console.WriteLine("any toy?" + anyToy.GetToy());
//     }
// }


public class Class<T> {
    private T item;
    public void AddItem(T newItem) {
        item = newItem;
    }
    public T GetItem() {
        return item;
    }
}

class Program {
    static void Main(string[] args) {
        Inventory<string> Bat = new Inventory<string>();
        pedang.AddItems("Bat");
        Console.WriteLine("Item dalam Bat:" + Bat.GetItem());
   
        Inventory<string> Gun = new Inventory<string>();
        pedang.AddItems("Gun");
        Console.WriteLine("Item dalam Senjata:" + Gun.GetItem());
        Inventory<string> Trownable = new Inventory<string>();
        pedang.AddItems("Grenade");
        Console.WriteLine("Item dalam Granat:" + Trownable.GetItem());
    }
}
