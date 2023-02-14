using System;

namespace CommonStudy
{
    public class MainClass
    {
        //DerivedClass dc = new DerivedClass();
        //Console.WriteLine("Total: ", dc.Add(4, 5)); // Error CS0509 'DerivedClass': cannot derive from sealed type 'BaseClass'
    }

    //public sealed class BaseClass // if declare as sealed keyboard then prevent from inherited by any other class, if class try to derive a sealed class then it's compile time error
    public class BaseClass
    {
        public void GetAge(int age)
        {
            Console.WriteLine("Name: Shashank Upadhyay, Age: ", age);
        }

        public int Add(int x, int y)
        {
            return x + y;
        }
    }

    public class DerivedClass : BaseClass
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}