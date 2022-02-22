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
            var person = new Person();
            person.Parse("John");
            //person.Name = "John";
            person.Introduce("Mosh");
        }
    }
}