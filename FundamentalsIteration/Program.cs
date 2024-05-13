using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            foreach(int i in arr)
            {
             if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                };
            };
        }
    }
}
