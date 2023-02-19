
using System;
using System.ComponentModel;
using System.Numerics;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 9, 12, 6, 32, 54, 1 };
            
            int minValue = myArray[0];

            for (int i=0; i < myArray.Length; i++)
            {
                if (minValue>myArray[i])
                {
                    minValue= myArray[i];
                }


            }
            Console.WriteLine(minValue);
        }
    }
}









    



        
        
           



        
    









          



