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
        public override string PickAGesture()
        {
           
            while (true)
            {
                Console.WriteLine("Select a hand gesture by entering the number assosiated with it: \n" + "--- ( 1 ) = Rock --- \n" + "--- ( 2 ) = paper --- \n" + "--- ( 3 ) = scissors --- \n" + "--- ( 4 ) = lizard --- \n" + "--- ( 5 ) = spock --- \n");
                ConsoleKeyInfo thing = Console.ReadKey();

                if (thing.Key == ConsoleKey.D1)
                {
                    gesture = "rock";
                    Console.WriteLine(" You picked rock!");
                    
                    return "rock";
                }
                else if (thing.Key == ConsoleKey.D2)
                {
                    gesture = "paper";
                    Console.WriteLine(" You picked paper!");
                    

                    return "paper";
                }
                else if (thing.Key == ConsoleKey.D3)
                {
                    gesture = "scissors";
                    Console.WriteLine(" You picked scissors!");
                    

                    return "scissors";
                }
                else if (thing.Key == ConsoleKey.D4)
                {
                    gesture = "lizard";
                    Console.WriteLine(" You picked the lizard!");
                    

                    return "lizard";

                }
                else if (thing.Key == ConsoleKey.D5)
                {
                    gesture = "spock";
                    Console.WriteLine(" You picked the spock!");
                    
                    return "spock";

                }
                else
                {
                    Console.WriteLine("Please try again and pick a gesture using its assigned number");
                   
                }
            }
           
            //ConsoleKeyInfo thing = Console.ReadKey();

            //if(thing.Key == ConsoleKey.D1)
            //{
            //    gesture = "rock";
            //    Console.WriteLine("You picked rock!");
            //    Console.ReadLine();
            //    return "rock";
            //}
            //else if (thing.Key == ConsoleKey.D2)


            //switch (results)
            //{
            //    case "1":
            //    case "One":
            //    case "one":
            //        gesture = "rock";
            //        Console.WriteLine("You picked Rock");
            //        return "rock";
            //    default:
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

            //}
        }

    }
}
