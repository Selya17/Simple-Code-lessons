﻿using System;
using System.ComponentModel;
using System.Numerics;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 12, 6, 32, 54, 1 };
            int temp;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array output:  ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + ",");
            }




        }
    }
}
