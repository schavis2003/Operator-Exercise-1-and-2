using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //OperatorExercise1
            //For division, create two integer variables called a and b.
            

            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

           //Console.WriteLine(a + " / " + b + " is " + quotient +  + " remainder " + remainder); This line kept giving me error, so I wrote the next line
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine("Please enter the radius of your circle");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle);
        }

        //OperationExercise2 - define a method - which performs some functioality, that can be used over and over again.

        public static double AreaOfCircle(double radius) 
        {
            //This is the scope of the method
            var area = Math.PI * Math.Pow(radius, 2);

            return Math.Sqrt(area);
        }

    }


}
