using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person andrew = new Person("Andrew");
            Console.WriteLine(andrew.Name);
            andrew.Display();
            Employee igor = new Employee("Igor", "BMZ");
            igor.Display();
            Console.WriteLine($"{andrew.Name}, {igor.Name}");
            Console.WriteLine($"{igor.Name}");
        }
    }
}
