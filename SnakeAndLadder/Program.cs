using SnakeAndLadder.services;
using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            Player player1 = new Player();
            Player player2 = new Player();

            while(player1.playerPosition < 100 && player2.playerPosition < 100)
            {
                player1.playerPostionManager();
                Console.WriteLine("Player 1 is at : " + player1.playerPosition);

                player2.playerPostionManager();
                Console.WriteLine("Player 2 is at : " + player2.playerPosition);

                counter++;
            }
            Console.WriteLine("Number of times dice was rolled : " + counter);

            Console.WriteLine(player1.playerPosition == 100 ? "Player 1 Won" : "Player 2 Won");
        }
    }
}
