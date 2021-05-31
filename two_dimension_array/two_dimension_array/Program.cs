using System;

namespace two_dimension_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to person record program");
            string[][] customers = new string[5][];
            for(int i=0; i<=4; i++)
            {
                customers[i] = new string[3];
                Console.WriteLine("Please fill your name");
                customers[i][0] = Console.ReadLine();
                Console.WriteLine("Please fill your address");
                customers[i][1] = Console.ReadLine();
                Console.WriteLine("Please fill your telephone number");
                customers[i][2] = Console.ReadLine();
            }

            for(int i=0; i<=4; i++)
            {
                string name = customers[i][0];
                string address = customers[i][1];
                string telNo = customers[i][2];
                Console.WriteLine("Person at" + i);
                Console.WriteLine("name: " + name);
                Console.WriteLine("Address: " + address);
                Console.WriteLine("Tel No. " + telNo);
            }
            Console.WriteLine("End Program");
            Console.ReadLine();
        }
    }
}
