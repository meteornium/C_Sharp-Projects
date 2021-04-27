using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Game Corner. Please tell me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance >0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thanks for playing!");
            }
            Console.WriteLine("Feel free to look around. Bye for now.");
            Console.ReadLine();
        }
    }
}
