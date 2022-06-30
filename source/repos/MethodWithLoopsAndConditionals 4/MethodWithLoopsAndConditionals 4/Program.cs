using System;

namespace MethodWithLoopsAndConditionals_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
                // Check if number is odd or even
                if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number.");
            } 

            
                else {
                Console.WriteLine($"{number} is an odd number.");
            }
        }
    }
}
