using C_Advanced02.StructConstrain;

namespace C_Advanced02;

internal class Program
{
    static void Main(string[] args)
    {
        #region C# Advanced
        #region Theoretical
        /*
         *   Q1: What is a generic class? Why use generics?
         *   Answer: A generic class is a class that can work with any data type, allowing you to create a single class definition that can be used with different types.
         *           we use generics to create reusable (one class can work with many data types) and type safe code (errors are detected by the compiler), better performance (avoids boxing/unboxing) and cleaner code (reduces code duplication and improves readability).
         */

        /*
         *   Q3:What are multiple type parameters?
         *   Answer: Multiple type parameters allow you to define a generic class or method that can work with more than one data type.
         */

        /*
         *   Q4: What is a generic method?
         *   Answer: A generic method is a method that uses a type parameter (T) so it can work with different data types without rewriting the method.
         */

        /*
         *   Q6: What is a generic interface?
         *   Answer: A generic interface is an interface that uses a type parameter (T), allowing it to be implemented by classes that work with different data types.
         */

        /*
         *   Q7: What is the 'struct' constraint? Write an example.
         *   Answer: The 'struct' constraint is a generic type constraint that restricts the type parameter to value types only (structs).
         *           Example : public class Box<T> where T : struct { }     ==> T can be any value type (int, float, double, etc.) but not a reference type
         */

        #endregion

        #region Practical
        //Container<int> numberContainer01 = new Container<int>();
        //numberContainer01.AddItem(100);
        //Console.WriteLine(numberContainer01.GetItem());

        //Container<string> numberContainer02 = new Container<string>();
        //numberContainer02.AddItem("Ahmed");
        //Console.WriteLine(numberContainer02.GetItem());


        //Pair<int, int> pair3 = new Pair<int, int>(3, 4);
        //pair3.Display();

        //Pair<string, string> pair2 = new Pair<string, string>("A", "Apple");
        //pair2.Display();

        //Pair<int, string> pair = new Pair<int, string>(1, "One");
        //pair.Display();


        #region Qu04
        //int n1 = 10, n2 = 20;
        //Utility.Swap(ref n1, ref n2);
        //Console.WriteLine($"n1 = {n1}, n2 = {n2}");

        //double d1 = 1.5, d2 = 2.5;
        //Utility.Swap(ref d1, ref d2);
        //Console.WriteLine($"d1 = {d1}, d2 = {d2}");
        #endregion

        #region Qu05
        //Console.WriteLine(Utility.FindMax(10, 20));
        //Console.WriteLine(Utility.FindMax(2.5, 2.5));
        //Console.WriteLine(Utility.FindMax("Ali", "Samy"));  // Comparison is based on lexicographical order
        #endregion

        #region Qu07
        //Box<int> intBox = new Box<int>();
        //Box<double> doubleBox = new Box<double>();
        //Box<decimal> decimalBox = new Box<decimal>();
        //Box<string> stringBox = new Box<string>();   // This will cause a compile-time error because string is a reference type
        #endregion

        #endregion

        #endregion

    }
}
