﻿using System;

namespace project_euler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            for (var i = 0; i <= 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("The sum is " + sum);
        }
    }
}
