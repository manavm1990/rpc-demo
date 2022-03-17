using System;
using System.Security;

namespace RockPaperScissorsDemo
{
    public class Player
    {
        public string Name { get; }
        public PlayerType TypeOfPlayer { get; }
        public ShootChoice Choice { get; set; }

        public Player(string name, PlayerType pt) // PlayerType...
        {
            Name = name;
            TypeOfPlayer = pt;

            // TODO: Go ahead with giving the ShootChoice whenever possible from the PlayerType
            // TODO: Actually use the enum names for clarity
            // TODO: Alternative syntax for switch statements
            switch ((int)pt)
            {
                case 1:
                    Choice = ShootChoice.Rock;
                    break;
                default
            }
        }
    }
}
