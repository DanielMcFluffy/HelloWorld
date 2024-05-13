using Fundamentals.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var john = new Person("John", "Smith");
            john.Introduce();
            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result) ;
        }
        
    }
}
