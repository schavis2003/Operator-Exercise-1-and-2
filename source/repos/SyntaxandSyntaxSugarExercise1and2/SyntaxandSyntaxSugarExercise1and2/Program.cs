using System;

namespace SyntaxandSyntaxSugarExercise1and2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            string response;

            if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + "greater than or equal to nine";
            }
            //Exercise 1
            //Snytax Sugar - this is syntax that is not required and not necessarily best practice,
            //but merely makes coding more convenient or concise.
            //Ternary - If, also called a ternary operator. It is essentially a normal If-Else statement
            //but in a more condensed format.

            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";
            Console.WriteLine(response);
             
        }
    }
}
