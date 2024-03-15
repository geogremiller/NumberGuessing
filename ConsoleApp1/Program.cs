using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isCorrectGuess = false;
            Random random = new Random();

            int randomNum = random.Next(1, 11);
            Console.WriteLine("Welcome to numeber guessing game");
            Console.WriteLine("A number between 1-10 will be generated");
            Console.WriteLine("If u guess the correct number then u won");

            while (!isCorrectGuess == true)
            {
                Console.WriteLine("Please enter your guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > randomNum)
                {
                    Console.WriteLine("Your guess is too high, try again!");
                }else if (guess < randomNum)
                {
                    Console.WriteLine("Your guess is too low, try again");
                }else
                {
                    Console.WriteLine("Correct");
                    isCorrectGuess = true;
                }
            }
            Console.WriteLine("Congratulation! You have won the game!");
            Console.ReadKey();
        }
    }
}
