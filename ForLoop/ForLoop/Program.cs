using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 12; i++)
            {
                int secondMutiply = i + 1;
                int resultMutiply = 10 * secondMutiply;
                Console.WriteLine("10x" + secondMutiply + "=" + resultMutiply);
            }
            Console.ReadLine();
        }
    }
}
