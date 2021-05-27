using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 5)
            {
                Console.WriteLine("Hello World");
                i = i + 1;
            }
            Console.ReadLine();
        }
    }
}
