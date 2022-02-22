using System;

namespace Classes // Note: actual namespace depends on the project name.
{
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }





    public class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("John");
            //person.Name = "John";
            person.Introduce("Mosh");
        }
    }
}
/*
 This is a use case for using a static member is static member. And it is only accessible from the class not an object.


Creating Objects

Person person = new Person();
var person = new Person(0;
 */