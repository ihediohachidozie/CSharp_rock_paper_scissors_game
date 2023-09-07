using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rock_paper_scissors_game
{
    /*
     * The following code is for the popular rock paper scissors game.
     * It accepts input (Ex. rock, paper or scissors) from the user 
     * and compare it with computers choice and determines the winner.
     * The application exits if the user enters nothing (null) and 
     * displays the result.
     */
    internal class Program
    {
        static int playerScore = 0, computerScore = 0, draw = 0;
        static void Main(string[] args)
        {
            string[] Choices = { "rock", "paper", "scissors" };

            while(true)
            {
                 Console.WriteLine("Make a choice (rock, paper, scissors) or press Enter key to quit:");

                 string playerChoice = Console.ReadLine().Trim();

                if (playerChoice.Length == 0)
                {
                    break;
                }

                Random choice = new Random();

                string computerChoice = Choices[choice.Next(0, 3)];

                Console.WriteLine($"\n{playGame(computerChoice, playerChoice)}\n");

                continue;
            }
            Console.Clear();
            Console.WriteLine("********** Game Over **********");
            Console.WriteLine($"Win: {playerScore}\nLoss: {computerScore}\nTie: {draw}");
            Console.Write("\nPress any key to exit the window.......");
            Console.ReadLine();

        }

        static string playGame(string computerChoice, string playerChoice)
        {
            string result = "";

            if (
                (computerChoice == "scissors" && playerChoice == "paper") || 
                (computerChoice == "rock" && playerChoice == "scissors") || 
                (computerChoice == "paper" && playerChoice == "rock")
                )
            {
                result = $"Computer choice {computerChoice} and you choose {playerChoice}\n{computerChoice} beats {playerChoice}. You lose.";

                computerScore++;
            }
            else if (
                (computerChoice == "paper" && playerChoice == "scissors") ||
                (computerChoice == "scissors" && playerChoice == "rock") ||
                (computerChoice == "rock" && playerChoice == "paper")
                )
            {
                result = $"Computer choice {computerChoice} and you choose {playerChoice}\n{playerChoice} beats {computerChoice}. You win!";

                playerScore++;
            }
            else if (computerChoice == playerChoice)
            {
                result = $"Computer choice {computerChoice} and you choose {playerChoice}\nIt is a tie!";

                draw++;
            }

            return result;
        }
    }
}
