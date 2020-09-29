using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPosition = 0;

            Random random = new Random();
            int dice = random.Next(1, 7);

            Console.WriteLine("Number on the dice : " + dice);

            playerPosition += dice;

            Console.WriteLine("Player is at : " + playerPosition);
        }
    }
}
