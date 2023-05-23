
// // class Program
// // {
// //     static void Main(string[] args)
// //     {
// //         int number = 10;
// //         PrintDouble(in number);
// //     }

// //     static void PrintDouble(in int x)
// //     {
// //         Console.WriteLine(x * 2); 
// //     //    x = 20;   //Error, Please read the error                       
// //     }
// // }

// // class Program
// // {
// // 	static void Main(string[] args)
// // 	{
// // 		int number1 = 10;
// // 		MultiplyAndAddByTwo(ref number1, out int number2); 
// // 		Console.WriteLine(number1);
// // 		Console.WriteLine(number2);
// // 	}

// // 	static void MultiplyAndAddByTwo(ref int x, out int y)
// // 	{
// // 		y = (x * 2) + 2;
// // 		x = y + 1;
// // 	}
// // }

// // class Program
// // {
// //     static void Main(string[] args)
// //     {
// //         int number = 10;
// //         MultiplyByTwo(ref number);
// //         Console.WriteLine(number); 
// //     }

// //     static void MultiplyByTwo(ref int x)
// //     {
// //         x = x * 2;
// //     }
// // }

// namespace RefOutInDemo
// {
//     static class Program
//     {
//         static void Main()
//         {
//             int x = 10;
//             int y = 20;
//             //int q = 0;
//             int q = 0;
//             Add(ref x, ref y);
//             Console.WriteLine($"After Add method, x={x}, y={y}");

//             Subtract(out x, out int z);
//             Console.WriteLine($"After Subtract method, x={x}, z={z}");

//             z = Multiply(in x, in q);
//             Console.WriteLine($"After Multiply method, x={x}, y={q}, z={z}");

//             q = Divide(in x, in y);
//             Console.WriteLine($"After Divide method, x={x}, y={y}, q={q}");
//         }

//         static void Add(ref int a, ref int b)
//         {
//             a++;
//             b++;
//         }

//         static void Subtract(out int a, out int b)
//         {
//             a = 10;
//             b = 20;
//             a--;
//             b--;
//         }

//         static int Multiply(in int a, in int b)
//         {
//             return a * b;
//         }

//         static int Divide(in int a, in int b)
//         {
//             return a / b;
//         }
//     }
// }


