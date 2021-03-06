﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder.services
{
    class Player
    {
        public const int LADDER = 1;
        public const int SNAKE = 2;

        public int playerPosition = 0;

        public void playerPostionManager()
        {
            Random random = new Random();

            int dice = random.Next(1, 7);
            int movement = random.Next(0, 3);

            Console.WriteLine("Number on the dice : " + dice);

            switch (movement)
            {
                case LADDER:
                    Console.WriteLine("Player climbs the ladder");
                    playerPosition += dice;
                    if (playerPosition > 100)
                        playerPosition -= dice;
                    break;

                case SNAKE:
                    Console.WriteLine("Player slides down the snake");
                    playerPosition -= dice;
                    if (playerPosition < 0)
                        playerPosition = 0;
                    break;

                default:
                    Console.WriteLine("No-Play by the player");
                    break;

            }
        }
    }
}
