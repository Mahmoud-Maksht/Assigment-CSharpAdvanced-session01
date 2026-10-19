using C__Advanced_session01.BaseConstriant;
using C__Advanced_session01.ClassConstraint;
using C__Advanced_session01.ConstraintInterface;
using C__Advanced_session01.Generic;
using C__Advanced_session01.Indexer;
using C__Advanced_session01.MultipleParameters;
using C__Advanced_session01.MultiplieConstriant;
using C__Advanced_session01.New__Constraint;
using C__Advanced_session01.StructConstraint;

namespace C__Advanced_session01;

internal class Program
{
    static void Main(string[] args)
    {
        #region Q1
        // Q1: What is a generic class? Why use generics?
        // A generic class is a class that can work with different data types using a type parameter such as T.
        // Because : Code Reusability: Write one class that works with different data types.
        // Performance: Reduce boxing and unboxing when working with value types.
        #endregion

        #region Q2
        //Container <int> container = new Container <int>();
        //container.Add (10);
        //Console.WriteLine(container.Get());
        #endregion

        #region Q3
        // Q3: What are multiple type parameters?
        // Multiple parameter allow generic class or method to use more different data type in the same time .
        //Pair<int, decimal> pair = new Pair <int , decimal>(10, 5.5m);
        //Console.WriteLine(pair.Value);
        //Console.WriteLine(pair.Key);
        #endregion

        #region Q4
        // Q4: What is a generic method?
        // Generic method is a method that uses a type parameter suchas T to work with different data type .
        //int x = 15;
        //int y = 10;
        //Container<int>.Swap<int>(ref x, ref y);
        //Console.WriteLine(x);
        //Console.WriteLine(y);
        #endregion

        #region Q5
        //int[] arr = { 10, 20, 8, 3, 30, 15 };
        //Console.WriteLine(Container<int>.FindMax(arr));
        #endregion

        #region Q6
        // Q6: What is a generic interface? 
        // Is a interface that uses a type parameter suchas T to work with different data type .
        #endregion

        #region Q7
        // Q7: What is the 'struct' constraint?
        // The struct constraint specifies that a generic type parameter must be a value type, such as int, double, or a user-defined struct.
        //MyStruct<int> myStruct = new MyStruct<int>();
        //MyStruct<string> @struct = new MyStruct<string>();
        #endregion

        #region Q8
        //Q8: What is the 'class' constraint?
        // The class constraint restricts a generic type T to reference types, such as classes, strings, and arrays.
        //MyClass<int> myClass = new MyClass<int>();
        //MyClass<string> @class = new MyClass<string>();
        #endregion

        #region Q9
        // Q9: What is the 'new()' constraint?
        // The new() constraint ensures that a generic type T has a public parameterless constructor, allowing us to create objects of type T using new T().

        //Product<MyNew> product = new Product<MyNew>();
        //MyNew my = product.Create();
        #endregion

        #region Q10
        // Q10: What is the interface constraint?
        // The interface constraint ensures that a generic type T implements a specific interface, allowing us to access the members defined in that interface.
        //Employee<Document> employee = new Employee<Document>();
        //Document document = new Document ();
        //employee.PrintItem(document);
        #endregion

        #region Q11
        //Q11: What is the base class constraint?
        // The base class constraint restricts a generic type T to a specific base class or any class derived from it. It allows us to access the members defined in the base class.

        //Files<Student> files = new Files<Student>();
        //Student student = new Student();
        //student.id = 8585;
        //files.PrintID(student);
        #endregion

        #region Q12
        // Q12: How do you apply multiple constraints?
        // Multiple constraints can be applied to a generic type using a comma-separated list after where T :. These constraints specify the requirements that the type T must satisfy.

        //AnimalBox<Cat> animalBox = new AnimalBox<Cat>();
        //Cat cat = new Cat();
        //cat.Name = "Kitty";
        //animalBox.ShowItem(cat);
        #endregion

        #region Q13
        // Q13: What does the 'default' keyword do in generics?
        // The default keyword returns the default value of a type. It returns 0 for numeric types, false for bool, and null for reference types.
        #endregion

        #region Q14
        //SafeList<int> numbers = new SafeList<int>(3);
        //numbers[0] = 10;
        //numbers[1] = 20;
        //numbers[3] = 30;
        //numbers[4] = 40;
        //Console.WriteLine(numbers[0]);
        //Console.WriteLine(numbers[1]);
        //Console.WriteLine(numbers[3]);
        #endregion

        #region Q15
        // Q15: What is covariance? Explain the 'out' keyword.
        // Covariance allows a generic type to use a more derived type than originally specified. The out keyword is used to support covariance in interfaces and delegates.
        //IEnumerable<string> names = new List<string>();
        //IEnumerable<object> objects = names;
        #endregion

        #region Q16
        // Q16: What is contravariance? Explain the 'in' keyword.
        // Contravariance allows a generic type to use a less derived type instead of a more derived type. The in keyword is used to support contravariance in interfaces and delegates.
        //IConsumer<Animal> animalConsumer = new AnimalConsumer();
        //IConsumer<Dog> dogConsumer = animalConsumer;
        #endregion

        #region Q17
        // Q17: What is the difference between covariance and contravariance?
        // Covariance (out): Allows using a more derived type. Example: IEnumerable<string> to IEnumerable<object>.
        //Contravariance(in): Allows using a less derived type. Example: Action<object> to Action<string>.
        #endregion

        #region Q18
        // Q18: How do static members work in generic types?
        // Static members in generic types belong to each constructed type separately. Each type argument has its own static members.
        #endregion

        #region Q19
        // Q19: How can you inherit from a generic class?
        // A class can inherit from a generic class by specifying a type argument for the base class.
        #endregion

    }
}
