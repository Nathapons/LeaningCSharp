using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do while => action before check condition
            // while => check condition before action
            int count = 0;
            do
            {
                Console.WriteLine("Hello" + count);
                count++;
            } while (count < 10);
            Console.ReadLine();
        }
    }
}
