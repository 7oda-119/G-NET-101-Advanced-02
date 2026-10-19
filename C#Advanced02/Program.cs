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

        #endregion
        #endregion

    }
}
