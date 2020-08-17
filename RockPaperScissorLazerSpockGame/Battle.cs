using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLazerSpockGame
{
    class Battle
    {
        Player playerOne;
        Player playerTwo;
        Computer computer;
        int playerOneScore;
        int playerTwoScore;
        int computerScore;
        Random rand;
        public Battle()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
            computerScore = 0;
            rand = new Random();

            GameIntro();
            ThrowGestures();
            DisplayWinner();
        }
        public void GameIntro()
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("-----  Rock --- Paper --- Scissors --- Lizard --- Spock --- Shoot!  -----");
            Console.WriteLine("- Welcome to the fastest hand slinging shootout this side of the patomac!");
            Console.WriteLine("--------------How many users do we have playing one or two?--------------");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("------------------------ ( 1 ) One User ---------------------------------");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("------------------------------ ( 2 ) Two Users --------------------------");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------------------------");
            string playerResult = Console.ReadLine();
            if (playerResult == "1")
            {
                playerOne = new User();
                playerTwo = new User();
            }
            else if (playerResult == "2")
            {
                playerOne = new User();
                computer = new Computer();
            }
        }
        public void ThrowGestures()
        {
            while (playerOneScore < 2 && playerTwoScore < 2)
            {
                Console.WriteLine("Player one, please pick a hand gesture to use");
                string playerOneGesture = playerOne.PickAGesture();
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Player two, please pick a hand gesture to use");
                string playerTwoGesture = playerTwo.PickAGesture();
                Console.ReadLine();
                Console.Clear();
                CompareGestures();
            }
            while (playerOneScore < 2 && computerScore < 2)
            {
                Console.WriteLine("Player one, please pick a hand gesture to use");
                string playerOneGester = playerOne.PickAGesture();
                Console.ReadLine();
                Console.Clear();
                string computerGester = computer.PickAGesture();
                CompareGestures();
            }
        }
        public void CompareGestures()
        {
            if (playerOne.gesture == playerTwo.gesture)
            {
                Console.WriteLine("Draw partner! Pick new gestures!");
            }
            else if (playerOne.gesture == "rock")
            {
                if (playerTwo.gesture == "scissors" || playerTwo.gesture == "lizard")
                {
                    playerOneScore++;
                    Console.WriteLine($"Player 1 picked: {playerOne.gesture}. Player 2 picked: {playerTwo.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                    Console.ReadLine();
                    Console.Clear();
                }

                else
                {
                    playerTwoScore++;
                    Console.WriteLine($"Player 2 picked: {playerTwo.gesture}. Player 1 picked: {playerOne.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else if (playerOne.gesture == "scissors")
            {
                if (playerTwo.gesture == "paper" || playerTwo.gesture == "lizard")
                {
                    playerOneScore++;
                    Console.WriteLine($"Player 1 picked: {playerOne.gesture}. Player 2 picked: {playerTwo.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    playerTwoScore++;
                    Console.WriteLine($"Player 2 picked: {playerTwo.gesture}. Player 1 picked: {playerOne.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else if (playerOne.gesture == "paper")
            {
                if (playerTwo.gesture == "rock" || playerTwo.gesture == "spock")
                {
                    playerOneScore++;
                    Console.WriteLine($"Player 1 picked: {playerOne.gesture}. Player 2 picked: {playerTwo.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    playerTwoScore++;
                    Console.WriteLine($"Player 2 picked: {playerTwo.gesture}. Player 1 picked: {playerOne.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else if (playerOne.gesture == "lizard")
            {
                if (playerTwo.gesture == "spock" || playerTwo.gesture == "paper")
                {
                    playerOneScore++;
                    Console.WriteLine($"Player 1 picked: {playerOne.gesture}. Player 2 picked: {playerTwo.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    playerTwoScore++;
                    Console.WriteLine($"Player 2 picked: {playerTwo.gesture}. Player 1 picked: {playerOne.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else if (playerOne.gesture == "spock")
            {
                if (playerTwo.gesture == "scissors" || playerTwo.gesture == "rock")
                {
                    playerOneScore++;
                    Console.WriteLine($"Player 1 picked: {playerOne.gesture}. Player 2 picked: {playerTwo.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    playerTwoScore++;
                    Console.WriteLine($"Player 2 picked: {playerTwo.gesture}. Player 1 picked: {playerOne.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        public void DisplayWinner()
        {
            if (playerOneScore > playerTwoScore)
            {
                Console.WriteLine("Player 1 wins!");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Player 2 wins!");
                Console.ReadLine();
                Console.Clear();
            }
        }

    }
}
 