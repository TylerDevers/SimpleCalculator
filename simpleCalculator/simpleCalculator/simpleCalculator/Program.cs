using System;

namespace simpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(); // testing Person Class
            Console.WriteLine(person1.GetAge());
            person1.SetAge(29);
            Console.WriteLine(person1.GetAge());
        }
    }
}
