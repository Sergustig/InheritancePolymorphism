using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public abstract class Animal
    {
        // Это Поле Name (Имя).
        // например Кот Tom, Мышь Jerry.
        public string Name;

        // Constructor по умолчанию.
        public Animal()
        {
            Console.WriteLine("- Animal()");
        }

        public Animal(string Name)
        {
            // Прикрепить значение полю Name.
            this.Name = Name;
            Console.WriteLine("- Animal(string)");
        }

        // Move(): Животное двигается.
        // virtual: Разрешить подклассу переопределить (override) данный метод.
        public virtual void Move()
        {
            Console.WriteLine("Animal Move");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }

    }
}
