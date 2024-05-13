using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit type conversion

            //type conversion makes the number type(byte) convert into an int type -- at during runtime this turns it from 1 byte memory to 4 bytes memory which basically turns it from ...0001 to 00000 00000 000001 (not accurate representation)

            //byte number = 1; 
            //int newNumber = number;

            //explicit type conversion

            //in terms of memory structure, data loss will happen as int is a bigger sized data into a small sized data type 

            //int i = 1;
            //byte b = i; //by default it won't compile 

            //int i = 1;
            //byte b = (byte)i; //append (byte) to explicitly do type conversion // this is called casting

            //incompatible type conversion
            //string s = "1";
            //int 1 = (int)s; //this won't convert as string and int aren't compatible

            //methods for type conversion
            //string s = "1";
            //int k = Convert.ToInt32(s);
            //int j = int.Parse(s);


            //try catch block example to catch exceptions(error)

            //try
            //{

            //var number = "1234";
            //int i = Convert.ToByte(number);
            //Console.WriteLine(i) ;
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("The number could not be converted to a byte.");
                
            //}

            try
            {

                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b) ;
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a boolean.");

            }

        }
    }
}
