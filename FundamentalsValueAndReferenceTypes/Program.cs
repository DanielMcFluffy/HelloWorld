using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsValueAndReferenceTypes
{
    public class Person
    {
        public int Age;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //value types
            var a = 10;
            var b = a; //the assignment 'b' is copying the value of a, not replacing the value  of 
            b++; // a will be 10 while b will be 11
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            //reference types
            //C# will assign the memory the array contents on the heap, which will have an address that will be shared among the arrays that are containing the contents 
            var array1 = new int[3]{ 1, 2, 3};
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(array1[0]); // array1[0] will be 0


            //example
            var number = 1;
            number = Increment(number);
            Console.WriteLine(number);
            //Console.WriteLine(number); // this will return 1 as the number variable is pointing to the var number = 1 -- to resolve it to 11, you need to assign a variable identifier e.g. var to the Increment(number) line to store the value
            //the number variable on var is not the same as the number variable in increment parameter

            var person = new Person() { Age = 20 };


        }

        public static int Increment(int number)
        {
            return number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }

    }
}
