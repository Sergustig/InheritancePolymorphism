using System;


namespace InheritancePolymorphism
{
    class PersonDemo
    {

        static void Main(string[] args)
        {

            // Объект: Thomas Edison.
            // Создан с помощью Constructor с 2-мя параметрами класса Person.
            Person edison = new Person("Thomas Edison", 1847);

            Console.WriteLine("Info:");
            Console.WriteLine("Name: " + edison.Name);
            Console.WriteLine("Born Year: " + edison.BornYear);
            Console.WriteLine("Place Of Birth: " + edison.PlaceOfBirth);

            // Объект: Bill Gates
            // Создан с помощью Constructor с 3-мя параметрами класса Person.
            Person billGates = new Person("Bill Gates", 1955, "Seattle, Washington");

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Info:");
            Console.WriteLine("Name: " + billGates.Name);
            Console.WriteLine("Born Year: " + billGates.BornYear);
            Console.WriteLine("Place Of Birth: " + billGates.PlaceOfBirth);

            Console.ReadLine();
        }
    }
}