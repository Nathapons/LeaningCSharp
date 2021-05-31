using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic Array ยังไม่มีการกำหนดข้อมูล
            int[] ages = new int[10];
            ages[0] = 18;
            ages[1] = 12;
            int[] ages2 = {18, 12, 14, 16, 28, 30};

            // For Each
            string[] countries = { "Thailand", "Laos", "Singapore" };
            foreach(string country in countries)
            {
                Console.WriteLine(country);
            }

            // Homework 1 
            //string[] firstNames = new string[3];
            //string[] lastNames = new string[3];
            //string[] salaries = new string[3];
            //int i = 0;
            //while (i < 3) 
            //{
            //    Console.WriteLine("Please enter your firstname and Lastname");
            //    firstNames[i] = Console.ReadLine();
            //    lastNames[i] = Console.ReadLine();
            //    Console.WriteLine("Please enter your salary");
            //    salaries[i] = Console.ReadLine();
            //    i++;
            //}

            //for (int j = 0; j < 3; j++)
            //{
            //    Console.WriteLine("Name list " + j);
            //    Console.WriteLine("His name is " + firstNames[j] + " " + lastNames[j]);
            //    Console.WriteLine("His salary is " + salaries[j]);
            //}

            // 2 Dimensional Array
        }
    }
}
