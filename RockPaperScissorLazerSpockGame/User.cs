﻿using System;
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
        public override int PickAGesture()
        {
            Console.WriteLine("Please pick the hand gesture you would like to use! \n" + "--- 1 = Rock --- \n" + "--- 2 = paper --- \n" + "--- 3 = scissors --- \n" + "--- 4 = lizard --- \n" + "--- 5 = spock --- \n");
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
                Console.WriteLine("Please try again and pick a gesture using its assigned number");
            }

            //switch (results)
            //{
            //    case "1":
            //        gesture = "rock";
            //        break;
            //    case "2":
            //        gesture = "paper";
            //        break;
            //    case "3":
            //        gesture = "scissors";
            //        break;
            //    case "4":
            //        gesture = "lizard";
            //        break;
            //    case "5":
            //        gesture = "spock";
            //        break;

        }
        }

    }
}
