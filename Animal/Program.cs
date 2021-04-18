using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create Cat object from Cat(string,int,int)");

            // Создать объект Cat с помощью конструктора с 3-мя параметрами.
            // Полю Name у Animal будет прикреплено значение "Tom".
            // Полю Age у Cat будет прикреплено значение 3
            // Полю Height у Cat будет прикреплено значение 20.
            Cat tom = new Cat("Tom", 3, 20);

            Console.WriteLine("------");

            Console.WriteLine("Name = {0}", tom.Name);
            Console.WriteLine("Age = {0}", tom.Age);
            Console.WriteLine("Height = {0}", tom.Height);

            Console.WriteLine("------");

            // Вызвать метод унаследованный от класса Animal.
            tom.Sleep();

            // Вызвать метод Say() (класса Cat)
            tom.Say();


            Console.ReadLine();
        }
    }
}
