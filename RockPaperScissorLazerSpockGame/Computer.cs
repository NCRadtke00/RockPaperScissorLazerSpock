﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLazerSpockGame
{
    public class Computer : Player
    {
        public Computer()
        {

        }
        public override string PickAGesture()
        {
            int randomNumber = RandomNumber(0, 4);
            gesture = gestures[randomNumber];
            return Convert.ToString(gestures[randomNumber]);
        }
        int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
