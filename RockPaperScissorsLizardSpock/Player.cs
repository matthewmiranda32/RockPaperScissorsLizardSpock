using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Player
    {
        public int choice;
        public int score;
        public string name;

        public virtual string MakeChoice()
        {
            Console.WriteLine("Please Make Your Choice:");
            string input = Console.ReadLine();
            choice = Convert.ToInt32(input);
            string result1 = "";
            if (choice == 0)
            {
                result1 = "rock";
            }
            else if (choice == 1)
            {
                result1 = "paper";
            }
            else if (choice == 2)
            {
                result1 = "scissors";
            }
            else if (choice == 3)
            {
                result1 = "lizard";
            }
            else if (choice == 4)
            {
                result1 = "Spock";
            }
            else
            {
                Console.WriteLine("Not a valid move. Please try again.");
            }
            Console.WriteLine(name+ " chose " + result1);
            return result1;
        }

        public void SetName()
        {
            Console.WriteLine("Please Enter Your Name:");
            name = Console.ReadLine();
        }

        public int PlayerScores()
        {
            return score;
        }
    }
}
