//importing the necessary namespaces
using System;

namespace HelloWorld
{
    internal class Program
    {
        //CLR executes the code in the Main method
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine(int.MaxValue);
            //int number;
            //Console.WriteLine(number);

            checked
            {
            var min = int.MinValue;
            Console.WriteLine(min);
            Console.WriteLine(min - 4);

            }
        }
    }
}
