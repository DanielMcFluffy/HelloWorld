using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsEnum
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express= 3
    }

    public enum test
    {
        test1, 
        test2 =2,
        test3,
    }


    internal class Program
    {
        //const int RegularAirMail = 1;
        //const int RegisteredAirMAil = 2;
        //const int Express = 3;

         //use enum for number of related constants



        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            //Console.WriteLine(method);
            Console.WriteLine((int)method); //we use casting to access the value 

            //let's say we receive a number 3 from somewhere in our application
            //we then want to convert that into a shipping method class
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId); //we use casting

            Console.WriteLine(method.ToString()); // will be the same as without ToString()

            //convert a string into an enum;

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
            //you then get an enum which you can use type casting to access the value
            Console.WriteLine((int)shippingMethod);

            //var testEnum = new test();
            Console.WriteLine(Enum.Parse(typeof(test), "2"));
            Console.WriteLine(Enum.IsDefined(typeof(test), 2));

            foreach(var data in Enum.GetNames(typeof(test)))
            {
                Console.WriteLine(data);
            }
            Console.WriteLine((test)1);
        }
    }
}
