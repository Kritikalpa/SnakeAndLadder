using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LADDER = 1;
            const int SNAKE = 2;

            int playerPosition = 0;

            Random random = new Random();

            while(playerPosition < 100)
            {
                int dice = random.Next(1, 7);
                int movement = random.Next(0, 3);

                Console.WriteLine("Number on the dice : " + dice);

                switch (movement)
                {
                    case LADDER:
                        Console.WriteLine("Player climbs the ladder");
                        playerPosition += dice;
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


                Console.WriteLine("Player is at : " + playerPosition);
            }
            
        }
    }
}
