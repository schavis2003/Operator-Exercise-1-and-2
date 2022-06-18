using System;

namespace Iteration
{
     class Program
    { 
        public static bool CanVote()

        { 
            bool canParse = false;
            int age = 0;
            //The “while” loop executes a statement or a block of statements while a specified Boolean expression evaluates to true.
            //Because that expression is evaluated before each execution of the loop, a while loop executes zero or more times.
            //This differs from the do-while loop which executes one or more times.
            //Use a while loop if you need to execute some code until something happens.

            ////The “do-while” loop executes a statement or a block of statements while a specified Boolean expression evaluates to true.
            //Because that expression is evaluated after each execution of the loop,
            //a do-while loop is guaranteed to execute at least one or more times.
            //Use a do-while loop if you need to execute some code at least once, then continue execution until something happens.


            while (!canParse)
            {
                Console.WriteLine("Please enter you age:");
                canParse = int.TryParse(Console.ReadLine(), out age);
            }
           
            if(age >= 18)

            {
                Console.WriteLine("You are old enough to vote.");
                return true;
            }
            else
            {
                Console.WriteLine( "Sorry, you are not old enough to vote.");
                return false;

            }
        }
            
        static void Main(string[] args)
        {
            //The “for” loop executes a statement or a block of statements while a specified Boolean expression evaluates to true.
            //Use a for loop if you need to execute some code a specific number of times.

            //for (int 0 = 1; i <= 100; i +=10)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 100; i >= 0; i--)
            
                Console.WriteLine(i);

             
            //A “foreach” loop executes a statement or a block of statements for each element in an instance of the type that implements the System.
            //Collections.IEnumerable; In other words, a “foreach” loop is used to iterate through collections such as Arrays or Lists.

            


        }
    }
}
