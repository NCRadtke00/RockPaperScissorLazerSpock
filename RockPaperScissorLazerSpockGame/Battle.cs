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
        int playerOneScore;
        int playerTwoScore;
        Random rand;

        public Battle()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
            rand = new Random();
           
        }
        public void RunGame()
        {
            GameIntro();
            ThrowGestures();
            Console.Clear();
            DisplayWinner();
        }
        public void GameIntro()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------                                                                   --------------");
            Console.WriteLine("--------------    Rock --- Paper --- Scissors --- Lizard --- Spock --- Shoot!    --------------");
            Console.WriteLine("--------------                                                                   --------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("---------                                                                              --------");
            Console.WriteLine("---------   Welcome to the fastest hand slinging shootout this side of the Atlantic!   --------");
            Console.WriteLine("---------                                                                              --------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------                            -----------------------------------------");
            Console.WriteLine("-----------------          It gets a bit wild out here          -------------------------------");
            Console.WriteLine("------------     if you remember the rules, you'll do just fine!       ------------------------");
            Console.WriteLine("-----------------                                               -------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("------------                                                           ------------------------");
            Console.WriteLine("------------        Rock crushed Scissors, Rock smashes Lizard         ------------------------");
            Console.WriteLine("------------                                                           ------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("------------                                                           ------------------------");
            Console.WriteLine("------------         Paper covers Rock, Paper disproves Spock          ------------------------");
            Console.WriteLine("------------                                                           ------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("------------                                                           ------------------------");
            Console.WriteLine("------------      Scissors cuts Paper, Scissors decapitates Lizard     ------------------------");
            Console.WriteLine("------------                                                           ------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("------------                                                           ------------------------");
            Console.WriteLine("------------          Lizard poisons Spock, Lizard eats Paper          ------------------------");
            Console.WriteLine("------------                                                           ------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("------------                                                           ------------------------");
            Console.WriteLine("------------       Spock smashes Scissors, Spock vaporizes Rock        ------------------------");
            Console.WriteLine("------------                                                           ------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("---------                                                                   -------------------");
            Console.WriteLine("---------      Please select how many users we have playing, one or two?    -------------------");
            Console.WriteLine("---------                                                                   -------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------                    ------------------------------------------------");
            Console.WriteLine("---------------------------   ( 1 ) One User   ------------------------------------------------");
            Console.WriteLine("---------------------------                    ------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------                     -----------------------------------------");
            Console.WriteLine("---------------------------------   ( 2 ) Two Users   -----------------------------------------");
            Console.WriteLine("---------------------------------                     -----------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            ConsoleKeyInfo thing = Console.ReadKey();
            if (thing.Key == ConsoleKey.D1)
            {
                playerOne = new User();
                playerTwo = new Computer();
            }
            else if (thing.Key == ConsoleKey.D2)
            {
                playerOne = new User();
                playerTwo = new User();
            }
            Console.Clear();
        }
        public void ThrowGestures()
        {
            while (playerOneScore < 2 && playerTwoScore < 2)
            {
                Console.WriteLine("Player one, please pick a hand gesture to use!");
                string playerOneGesture = playerOne.PickAGesture();
                Console.ReadLine();
                Console.WriteLine("Player two's turn to pick!");
                string playerTwoGesture = playerTwo.PickAGesture();
                Console.ReadLine();           
                CompareGestures();
            }
        }
        public void CompareGestures()
        {
            if (playerOne.gesture == playerTwo.gesture)
            {
                Console.WriteLine("Draw partner! Please pick new gestures!");
            }
            else if (playerOne.gesture == "rock")
            {
                if (playerTwo.gesture == "scissors" || playerTwo.gesture == "lizard")
                {
                    playerOneScore++;
                    Console.WriteLine($"Player 1 picked: {playerOne.gesture}. Player 2 picked: {playerTwo.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                    Console.ReadLine();
                }
                else
                {
                    playerTwoScore++;
                    Console.WriteLine($"Player 2 picked: {playerTwo.gesture}. Player 1 picked: {playerOne.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                    Console.ReadLine();
                }
            }
            else if (playerOne.gesture == "scissors")
            {
                if (playerTwo.gesture == "paper" || playerTwo.gesture == "lizard")
                {
                    playerOneScore++;
                    Console.WriteLine($"Player 1 picked: {playerOne.gesture}. Player 2 picked: {playerTwo.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                    Console.ReadLine();
                }
                else
                {
                    playerTwoScore++;
                    Console.WriteLine($"Player 2 picked: {playerTwo.gesture}. Player 1 picked: {playerOne.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                    Console.ReadLine();
                }
            }
            else if (playerOne.gesture == "paper")
            {
                if (playerTwo.gesture == "rock" || playerTwo.gesture == "spock")
                {
                    playerOneScore++;
                    Console.WriteLine($"Player 1 picked: {playerOne.gesture}. Player 2 picked: {playerTwo.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                    Console.ReadLine();
                }
                else
                {
                    playerTwoScore++;
                    Console.WriteLine($"Player 2 picked: {playerTwo.gesture}. Player 1 picked: {playerOne.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                    Console.ReadLine();
                }
            }
            else if (playerOne.gesture == "lizard")
            {
                if (playerTwo.gesture == "spock" || playerTwo.gesture == "paper")
                {
                    playerOneScore++;
                    Console.WriteLine($"Player 1 picked: {playerOne.gesture}. Player 2 picked: {playerTwo.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                    Console.ReadLine();
                }
                else
                {
                    playerTwoScore++;
                    Console.WriteLine($"Player 2 picked: {playerTwo.gesture}. Player 1 picked: {playerOne.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                    Console.ReadLine();
                }
            }
            else if (playerOne.gesture == "spock")
            {
                if (playerTwo.gesture == "scissors" || playerTwo.gesture == "rock")
                {
                    playerOneScore++;
                    Console.WriteLine($"Player 1 picked: {playerOne.gesture}. Player 2 picked: {playerTwo.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                    Console.ReadLine();
                }
                else
                {
                    playerTwoScore++;
                    Console.WriteLine($"Player 2 picked: {playerTwo.gesture}. Player 1 picked: {playerOne.gesture}. Player 1 score is currently: {playerOneScore}. Player 2 score is currently: {playerTwoScore}.");
                    Console.ReadLine();
                }
            }
        }
        public void DisplayWinner()
        {
            if (playerOneScore > playerTwoScore)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                Console.WriteLine("--------------------------------------                              ---------------------------------------");
                Console.WriteLine("--------------------------------------      Player One Wins!        ---------------------------------------");
                Console.WriteLine("--------------------------------------                              ---------------------------------------");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                Console.WriteLine("--------------------------                              ---------------------------------------------------");
                Console.WriteLine("--------------------------      Player Two Wins!        ---------------------------------------------------");
                Console.WriteLine("--------------------------                              ---------------------------------------------------");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
 