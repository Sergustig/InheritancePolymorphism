using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public class Cat : Animal
    {

        public int Age;
        public int Height;

        // Это Constructor имеющий 3 параметра класса Cat.
        // Использовать :base(name) для вызова Constructor родительского класса: Animal(string).
        // Полям родительского класса прикрепится значение.
        // Затем, полям данного класса прикрепится значение.
        public Cat(string name, int Age, int Height)
            : base(name)
        {
            this.Age = Age;
            this.Height = Height;
            Console.WriteLine("- Cat(string,int,int)");
        }

        // Данный Constructor вызывает Constructor по умолчанию (Без параметров) родительского класса.
        public Cat(int Age, int Height)
            : base()
        {
            this.Age = Age;
            this.Height = Height;
            Console.WriteLine("- Cat(int,int)");
        }

        public void Say()
        {
            Console.WriteLine("Meo");
        }

        // Переопределить метод Move() родительского класса (Animal).
        // Переписать данный метод,
        // чтобы описать точно поведения движения котов.
        public override void Move()
        {
            Console.WriteLine("Cat Move ...");
        }
    }
}
