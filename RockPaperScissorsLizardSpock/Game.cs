using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        Player playerOne;
        Player playerTwo;

        public void RunGame() 
        {
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.MakeChoice();
                playerTwo.MakeChoice();
                ChoiceComparison();
                FindAWinnerGame();
            }
            //determine a winner of the round
            //determine if there is a winner of the game (best two out of three)
            //if there is a game winner, play again?
        }
        public void DisplayRules() 
        {
            Console.WriteLine("You are about to play 'Rock-Paper-Scissors-Lizard-Spock'. The rules are as follows: Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, Spock smashes Scissors, Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock, and (as it always has), Rock crushes Scissors. Best 2 out of 3 wins.");
            Console.WriteLine("Please type 0 for Rock, 1 for Paper, 2 for Scissors, 3 for Lizard and 4 for Spock.");
        }
        public void GetNumberOfPlayers()
        {
            Console.WriteLine("Play by yourself or with another player? Type 1 for myself and 2 for another player");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                playerOne = new Human();
                playerTwo = new Computer();
                playerOne.SetName();
            }
            else if (userInput == "2")
            {
                playerOne = new Human();
                playerTwo = new Human();
                playerOne.SetName();
                playerTwo.SetName();
            }
            else
            {
                Console.WriteLine("Input not recognized. Please type myself or with another.");
                GetNumberOfPlayers();
            }
        }
         public void ChoiceComparison()
         {
            int choice = (5 + playerOne.choice - playerTwo.choice) % 5;

            if(choice == 1 || choice == 3)
            {
                Console.WriteLine("Player 1 Wins.");
                playerOne.score ++;
            }
            else if(choice == 2 || choice == 4)
            {
                Console.WriteLine("Player 2 Wins.");
                playerTwo.score ++;
            }
            else 
            {
                Console.WriteLine("It's a tie. Play again");
            }
         }
          public void FindAWinnerGame()
          {
          if(playerOne.score > 1)
          {
                Console.WriteLine("Player 1 Wins the Game.");
                Console.ReadLine();
          }
          else if(playerTwo.score > 1)
          {
                Console.WriteLine("Player 2 Wins the Game.");
                Console.ReadLine();
          }
          }
         }
        }
