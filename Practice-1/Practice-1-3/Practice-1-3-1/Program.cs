
using System;

namespace pr_01_03_01
{
    class Program
    {
        class Person
        {
            public enum Genders : int
            {
                Male,
                Female
            };

            public string FirstName;
            public string LastName;
            public int Age;
            public Genders Gender;

            public Person(string firstName, string lastName, int _age, Genders gender)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                Gender = gender;
            }

            public override string ToString()
            {
                return FirstName + " " + LastName + " (" + Gender + "), age " + Age;
            }
        }

        class Manager : Person
        {
            public string PhoneNumber;
            public string OfficeLocation;

            public Manager(string firstName, string lastName, int age, Genders gender, string phoneNumber,
                string officeLocation) : base(firstName, lastName, age, gender)
            {
                PhoneNumber = phoneNumber;
                OfficeLocation = officeLocation;
            }

            public override string ToString()
            {
                return base.ToString() + ", " + PhoneNumber + ", " + OfficeLocation;
            }
        }

        static void Main(string[] args)
        {
            Manager m = new Manager("Tony", "Allen", 32, Person.Genders.Male, "82223333535",
                "Street, Street2");
            Console.WriteLine(m);
        }
    }
}