using System;

namespace FirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            sayHelloWorldTenTimes();
            Console.ReadLine();
        }

        private static void sayHelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        private static void sayHelloWorldTenTimes()
        {
            for (int i=1; i<=10; i++)
            {
                Console.WriteLine("Hello World");
            }
        }
    }
}
