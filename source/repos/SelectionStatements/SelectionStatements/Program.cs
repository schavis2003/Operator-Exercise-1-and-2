using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Exercise 1
            //Create a program that allows a user to play a game where they must guess what your favorite number is:
            //Initialize an integer to represent a favorite number and assign a value with a number of your choosing or you can assign a random number to this variable:
            //Number Guessing Game
            //var r = new Random();
            //var favNumber = r.Next(1, 10)

            //Console.WriteLine("Pick a number from 1 - 1000");
            //var userInput = int.Parse(Console.ReadLine());

            //Create an if-statement that if the guessed number is below the initial value, print out “too low”.
            //if (userInput < favNumber)
            {
                //Console.WriteLine($"({userInput} is too low");
            }
            //Create an else-if statement that if the number is higher than the initial value, print out “too high”.
            //else if (userInput > favNumber)
            {
                //Console.WriteLine($"{userInput} is too high");
            }
            //Create an else statement that prints out some type of congratulations for guessing the correct number e.g. “You guessed it!!!”.
            //else
            {
            //Console.WriteLine("You guessed it!); "Request Helping...Why is my program not running"
            }


            {
                //Exercise 2
                Console.WriteLine("What is your favorite school subject?");

                var subject = Console.ReadLine();

                switch (subject)
                {
                    case "Math":
                        Console.WriteLine("Math is a tough subject!");
                        break;

                    case "Science":
                        Console.WriteLine("Science is a tough subject!");
                        break;

                    case "English":
                        Console.WriteLine("English is an interesting subject.");
                        break;

                    case "Algebra":
                        Console.WriteLine("Algebra is a mindboggling subject!");
                        break;

                    case "Gym":
                        Console.WriteLine("Gym is a fun and healthly subject for everyone, I think");
                        break;

                    default:
                        Console.WriteLine("Oh wow! I haven't taken that subject before.");
                        break; 


                    



                }

            }
        }
    }
}
