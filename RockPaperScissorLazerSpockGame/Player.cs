﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLazerSpockGame
{
    public abstract class Player
    {
        public string name;
        public int score;
        public string gesture;
        public List<string> gestures;
        public Player()
        {
            Gestures();
        }
        public abstract string PickAGesture();
        public void Gestures()
        {
            gestures = new List<string>();
            this.gestures.Add("rock");
            this.gestures.Add("paper");
            this.gestures.Add("scissors");
            this.gestures.Add("lizard");
            this.gestures.Add("spock");
        }
    }
}
