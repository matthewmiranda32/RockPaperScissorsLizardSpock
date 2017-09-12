using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Computer: Player
    {

        public override string MakeChoice()
        {
            Random random = new Random();
            choice = random.Next(0, 5);
            string result = "";
            if (choice == 0)
            {
                result = "rock";
            }
            else if (choice == 1)
            {
                result = "paper";
            }
            else if (choice == 2)
            {
                result = "scissors";
            }
            else if (choice == 3)
            {
                result = "lizard";
            }
            else if (choice == 4)
            {
                result = "Spock";
            }
            Console.WriteLine("The computer chose " + result);
            return result;
        }
    }
}
