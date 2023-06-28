using System.Reflection.Metadata;
using System;
using System.Reflection.Metadata.Ecma335;
using System.ComponentModel.Design;

namespace Game
{
    class Program
    {

        static string Winner(string user, string computer)
        {
            if (user == computer)
            {
                return "Its a draw";
            }
            else if ((user == "rock" && computer == "scissors") || (user == "paper" && computer == "rock") || (user == "scissors" && computer == "paper"))
            {
                return "You win";
            }
            else
            {
                return "Computer wins";
            }
           
        }
        static void Main(string[] args)
        {
            while (true) {
                //Prompt the user to enter an input

                Console.WriteLine("Welcome to Code Gamers Rock Paper Scissors !");
                Console.WriteLine("It's a game you play with the machine.Please follow the following instructions to begin");
                Console.WriteLine("Please press ANY key to play");
                Console.ReadKey();//computer reads the key that the user presses
                Console.WriteLine("");
                Console.Write("Enter your move ROCK/PAPER/SCISSORS:");
            string user = Console.ReadLine().ToLower();
                


            //user if statements to ensure the user choses the correct move
            if (user != "rock" && user != "paper" && user != "scissors")
            {
                    Console.WriteLine("Invalid move.Please enter the correct move");
                    // continue function skips the next part of the code and repeats the previous one until conditions have been met
                continue;
            }

            //Generate computer move
            //Use random numberes
            Random move = new Random();
            int randMove = move.Next(3); //Generating a random number

            //Use arrays to choose the move
            //Create an array that contains 3 possible moves
            string[] moves = { "rock", "paper", "scissors" };
            string computer = moves[randMove];

            Console.WriteLine("Computer chose " + computer);

                //Determine the winner

                Console.WriteLine(Winner(user, computer));

            //Prompt user user to play again
            Console.WriteLine("Do you want to play again (Y/N) ? ");
            string repeat = Console.ReadLine();

            //
            if (repeat == "Y" || repeat == "y") {
                    continue;
            }
            else
                {
                    break;//terminates anything but yes
                }
        }

            Console.WriteLine("Thanks for playing our Game");
           
        }
    }
}