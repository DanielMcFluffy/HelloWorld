using System;

namespace Fundamentals
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        
        public  Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}
