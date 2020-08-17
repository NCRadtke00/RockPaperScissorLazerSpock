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
        }

    }
}
