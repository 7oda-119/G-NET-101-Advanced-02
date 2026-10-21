using C_Advanced02.BaseClassConstrain;
using C_Advanced02.ClassConstrain;
using C_Advanced02.InAndOut;
using C_Advanced02.InterfaceConstrain;
using C_Advanced02.MultibleConstrain;
using C_Advanced02.NewConstrain;
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

        /*
         *   Q8: What is the 'class' constraint? Write an example.
         *   Answer: The 'class' constraint is a generic type constraint that restricts the type parameter to reference types only (classes).
         *           Example : public class Repository<T> where T : class { }     ==> T can be any reference type (string, object, etc.) but not a value type
         */

        /*
         *   Q9: What is the 'new()' constraint? Write an example.
         *   Answer: The 'new()' constraint is a generic type constraint that restricts the type parameter to types that have a public parameterless constructor.
         *           Example : public class Factory<T> where T : new() { }     ==> T must have a public parameterless constructor
         */

        /*
         *   Q10: What is the interface constraint? Write an example.
         *   Answer: The interface constraint is a generic type constraint that restricts the type parameter that implements a specific interface.
         *           Example : public class MyGenericClass<T> where T : IPrintable { }     ==> T must implement the IPrintable interface
         */

        /*
         *   Q11: What is the base class constraint? Write an example.
         *   Answer: The base class constraint is a generic type constraint that restricts the type parameter that inherits from a specific base class.
         *           Example : public class Manager<T> where T : Person { }     ==> T must inherit from the Person class
         */

        /*
         *   Q12: How do you apply multiple constraints? Write an example. 
         *   Answer: You can apply multiple constraints by separating them with commas in the where clause. The constraints must be specified in the following order:
         *           The first One of struct, class, or a base class. Second One or more interfaces. Third the new() constraint (must be last)
         *           Example : public class SoundPlayer<T> where T : class, ISound, new() { }     ==> T must be a reference type, implement the ISound interface, and have a public parameterless constructor
         */

        /*
         *   Q13: What does the 'default' keyword do in generics?
         *   Answer: The default keyword returns the default value of a type parameter T. Since T can be a value type or a reference type, default provides a default value of a type automatically.
         */

        /*
         *   Q15: What is covariance? Explain the 'out' keyword.
         *   Answer: Covariance allows you to use a more derived (child) type than originally specified, Its applied to output positions (such as return types of methods or read-only properities) and is marked with the out keyword.
         */

        /*
         *   Q16: What is contravariance? Explain the 'in' keyword.
         *   Answer: Contravariance allows you to use a less derived (parent/base) type than originally specified. It is applied to input positions (such as method parameters) and is marked with the in keyword.
         */

        /*
         *   Q17: What is the difference between covariance and contravariance?
         *   Answer: Covariance (out): Uses the out keyword. Used for output/return values. It allows assigning a generic type with a derived type to one with a base type.
         *           Contravariance (in): Uses the in keyword. Used for input parameters. It allows assigning a generic type with a base type to one with a derived type.
         */

        /*
         *   Q18: How do static members work in generic types?
         *    Answer: Static members in generic types are separate for each closed generic type. This means that each type parameter gets its own copy of the static field, property, or method.
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

        #region Qu08
        //Repository<string> stringRepository = new Repository<string>("Hello");
        //Repository<Person> personRepository = new Repository<Person>(new Person { Name = "John" });
        //Repository<int> intRepository = new Repository<int>(42);  // This will cause a compile-time error because int is a value type
        #endregion

        #region Qu09
        //Factory<Person> personFactory = new Factory<Person>();
        //Factory<Student> studentFactory = new Factory<Student>();
        //Factory<string> stringFactory = new Factory<string>();  // This will cause a compile-time error because string does not have a public parameterless constructor
        #endregion

        #region Qu10
        //Image image = new Image();
        //Printer<Image> printer = new Printer<Image>();
        //printer.PrintItem(image);
        //Person person = new Person();
        //printer.PrintItem(person);  // This will cause a compile-time error because Person does not implement IPrintable
        #endregion

        #region Qu11
        //Employee person = new Employee();
        //Manager<Employee> manager = new Manager<Employee>();
        //manager.DisplayInfo(person);

        //Student student = new Student();
        //Manager<Student> studentManager = new Manager<Student>();  // This will cause a compile-time error because Student does not inherit from Person
        #endregion

        #region Qu12
        //SoundPlayer<Dog> dogSound = new SoundPlayer<Dog>();
        //dogSound.Play();

        //SoundPlayer<Cat> catSound = new SoundPlayer<Cat>();  // This will cause a compile-time error because Cat does not implement ISound
        #endregion

        #region Qu14
        //SafeList<int> numbers = new SafeList<int>();
        //numbers.AddItem(10);
        //numbers.AddItem(15);
        //numbers.AddItem(20);

        //Console.WriteLine(numbers.GetItem(1)); 
        //Console.WriteLine(numbers.GetItem(5));  // output will be 0 because there are no index 5

        //SafeList<string> names = new SafeList<string>();
        //names.AddItem("Ahmed");
        //names.AddItem("Ali");

        //Console.WriteLine(names.GetItem(0)); 
        //Console.WriteLine(names.GetItem(4));  // output will be null because there are no index 4
        #endregion

        #region Qu15
        //IProducer<Car> carProducer = new CarProducer();     // carProducer points to a CarProducer object that return new Car()
        //IProducer<Vehical> vehicalProducer = carProducer;   // Covariance: IProducer<Car> can be assigned to IProducer<Vehicle>
        //Vehical vehicle = vehicalProducer.Get();            // Get() returns a Car object, but it is stored in a Vehicle reference
        //Console.WriteLine(vehicle.GetType().Name);
        #endregion

        #region Qu16
        //IProcessor<Vehical> vechicalProducer = new VehicleProcessor();   // vechicalProducer points to a VehicleProcessor object
        //IProcessor<Car> carProcesseor = vechicalProducer;                // Contravariance: IProcessor<Vehicle> can be assigned to IProcessor<Car>
        //carProcesseor.Processs(new Car("Hundai"));                       // A Car object is passed to Process(), This is valid because Car inherits from Vehicle ==> Car is a Vehical
        #endregion

        #region Question18
        //Counter<int> counter01 = new Counter<int>();
        //Counter<int> counter02 = new Counter<int>();
        //Counter<int> counter03 = new Counter<int>();

        //Counter<string> counter04 = new Counter<string>();
        //Counter<string> counter05 = new Counter<string>();
        //Console.WriteLine(Counter<int>.count);       // return 3
        //Console.WriteLine(Counter<string>.count);    // return 2
        #endregion
        #endregion

        #endregion

    }
}
