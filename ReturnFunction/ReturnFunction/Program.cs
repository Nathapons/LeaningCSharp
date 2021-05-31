using System;

namespace ReturnFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input first value");
            int firstInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input second value");
            int secondInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Your answer as below");
            Console.WriteLine("Plus value = " + plusCal(firstInput, secondInput));
            Console.WriteLine("Minus value = " + minusCal(firstInput, secondInput));
            Console.WriteLine("Multiply value = " + multiplyCal(firstInput, secondInput));
            Console.WriteLine("Division value = " + divisionCal(firstInput, secondInput));
            Console.WriteLine("---- End Program ----");
        }

        private static int plusCal(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        private static int minusCal(int a, int b)
        {
            int minus = a - b;
            return minus;
        }

        private static int multiplyCal(int a, int b)
        {
            int multiply = a * b;
            return multiply;
        }

        private static int divisionCal(int a, int b)
        {
            int division = a / b;
            return division;
        }
    }
}
