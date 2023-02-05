using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleInput = int.Parse(Console.ReadLine());
            var consoleInput2 = int.Parse(Console.ReadLine());
            

            Console.WriteLine(ToSum(consoleInput, consoleInput2));
            
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

        private static int Addition(int addition)
        {
            var sum = 0;
            for(int i = 0;i < addition; i++)
            {
                sum += i;
            }

            return sum;
        }

        private static int ToSum(int number1, int number2)
        {
            var sum = 0;
            sum = number1 + number2;
            return sum;
        }
    }
}
