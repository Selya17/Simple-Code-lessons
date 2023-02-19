
using MySqlX.XDevAPI.Common;
using Nest;
using Org.BouncyCastle.Tls;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Lessons
{
    class Program
    {


        static int Foo(int value)
        {
            if (value < 10)
                return value;

           int digit = value % 10;

          int nextValue = value/ 10;

            return  digit + Foo(nextValue);
            

        }   

        static void Main(string[] args)
        {

            int myValue = 25;
            int result = Foo(myValue);

            Console.WriteLine(result);
        }
    }

}




        
        

    

 

















