﻿using System;

namespace Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            if (score >= 80)
            {
                Console.WriteLine("A");
            }
            else if (score >= 70)
            {
                Console.WriteLine("B");
            }
            else if (score >= 60)
            {
                Console.WriteLine("C");
            }
            else if (score >= 50)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
            Console.ReadLine();
        }
    }
}
