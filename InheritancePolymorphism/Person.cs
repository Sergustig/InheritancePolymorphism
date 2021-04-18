using System;


namespace InheritancePolymorphism
{
    class Person
    {
        // Поле name - информация имена человека
        public String Name;

        // Поле bornYear - информация даты рождения
        public int BornYear;

        // Место рождения
        public String PlaceOfBirth;

        // Данный Constructor  имеет 3 параметра.
        // Цель инициализировать значения для полей Person.
        // Определить ясно имя, дату рождения, место рождения.
        public Person(String Name, int BornYear, String PlaceOfBirth)
        {
            this.Name = Name;
            this.BornYear = BornYear;
            this.PlaceOfBirth = PlaceOfBirth;
        }

        // Данный Constructor  имеет 2 параметра.
        // Цель инициализировать значения для 2 полей имени и даты рождения для Person.
        // Место рождения не инициализируется.
        // пробуем git
        public Person(String Name, int BornYear)
        {
            this.Name = Name;
            this.BornYear = BornYear;
        }
    }
}
