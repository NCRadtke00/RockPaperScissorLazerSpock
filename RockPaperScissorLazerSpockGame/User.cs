using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLazerSpockGame
{
    public class User : Player
    {
        public User()
        {

        }
        public override void PickAGesture()
        {
            Console.WriteLine("Pick the Gesture you would like to use! \n" + "--- 1 = Rock --- \n" + "--- 2 = paper --- \n" + "--- 3 = scissors --- \n" + "--- 4 = lizard --- \n" + "--- 5 = spock --- \n");
            string results = Console.ReadLine();

            if (results == "1" || results == "One" || results == "one")
            {
                gesture = "rock";
            }
            else if (results == "2" || results == "Two" || results == "two")
            {
                gesture = "paper";
            }
            else if (results == "3" || results == "Three" || results == "three")
            {
                gesture = "scissors";
            }
            else if (results == "4" || results == "Four" || results == "four")
            {
                gesture = "lizard";
            }
            else if (results == "5" || results == "Five" || results == "five")
            {
                gesture = "spock";
            }
            else
            {
                Console.WriteLine("Please pick a gesture use its assigned number");
            }


        }

    }
}
