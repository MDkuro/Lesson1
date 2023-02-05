using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleInput = Console.ReadLine();
            if (!int.TryParse(consoleInput, out var intInput))
            {
                return;
            }

            Console.WriteLine(CalcFactorial(intInput));
        }

        private static int CalcFactorial(int factor)
        {
            var sum = 1;
            for (int number = 2; number <= factor; number++)
            {
                sum *= number;
            }

            return sum;
        }
    }
}
