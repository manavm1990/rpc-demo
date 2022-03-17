using System;
using System.Security;

namespace RockPaperScissorsDemo
{
    public class Player
    {
        private readonly Random _random = new Random();
        public string Name { get; }
        public PlayerType TypeOfPlayer { get; }
        public ShootChoice? Choice { get; set; }

        public Player(string name, PlayerType pt)
        {
            Name = name;
            TypeOfPlayer = pt;

            switch (pt)
            {
                case PlayerType.Random:
                {
                    Choice = (ShootChoice) _random.Next(1, 4);
                    break;
                }
                case PlayerType.Rock:
                {
                    Choice = ShootChoice.Rock;
                    break;
                }
                case PlayerType.Paper:
                {
                    Choice = ShootChoice.Paper;
                    break;
                }
                case PlayerType.Scissors:
                {
                    Choice = ShootChoice.Scissors;
                    break;
                }
                default:
                {
                    Choice = null;
                    break;
                }
            }
        }
    }
}
