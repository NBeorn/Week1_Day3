﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int firstNumber = 2;
            //int secondNumber = 6;

            //if(firstNumber > secondNumber)
            //{
            //    Console.WriteLine("You have broken math. Good job.");
            //}
            //else
            //{
            //    Console.WriteLine("That makes sense.");
            //}

            //Console.WriteLine("What day is today?");
            //string userAnswer = Console.ReadLine();

            //if (userAnswer == "Monday")
            //{
            //    Console.WriteLine("Back to work");
            //}
            //else if (userAnswer == "Friday")
            //{
            //    Console.WriteLine("TGIF!");
            //}
            //else
            //{
            //    Console.WriteLine("Bloop");
            //}

            //Console.WriteLine("How old are you?");
            //int userAge = int.Parse(Console.ReadLine());

            //if(userAge >= 0 && userAge <= 1)
            //{
            //    Console.WriteLine("You're just a baby!");
            //}
            //else if(userAge > 1 && userAge < 4)
            //{
            //    Console.WriteLine("Yay toddlers!");
            //}
            //else if(userAge >= 4 && userAge < 13)
            //{
            //    Console.WriteLine("Enjoy your childhood");
            //}
            //else if (userAge >= 13 && userAge < 65)
            //{
            //    Console.WriteLine("Life is awkward.");
            //}
            //else if (userAge >= 65 && userAge < 100)
            //{
            //    Console.WriteLine("Enjoy your retirement");
            //}
            //else
            //{
            //    Console.WriteLine("That's not really your age.");
            //}

            //use 'else if' to account for a range in numbers
            //switch does not account for a range

            Console.WriteLine("How many points did you earn");
            int pointsEarned = int.Parse(Console.ReadLine());

            switch (pointsEarned)
            {
                case 0:
                    Console.WriteLine("You lose");
                    break;
                case 1:
                    Console.WriteLine("Needs practice");
                    break;
                case 2:
                    Console.WriteLine("On target");
                    break;
                case 3:
                    Console.WriteLine("Superstar");
                    break;
                case 4:
                    Console.WriteLine("Overachiever");
                    break;
                case 5:
                    Console.WriteLine("You cheated");
                    break;
                default:
                    Console.WriteLine("Invalid score entered");
                    break;
            }
        }
    }
}
