using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsGame
{
    class Game
    {
        private bool finished;
        private GamePlayer player;
        private GameBoard board;
        public Game()
        {
            player = new GamePlayer();
            board = new GameBoard();
            finished = false;
        }
        static void Main(string[] args)
        {
            Game game= new Game();
            Console.Write("Welcome to Battleships! What is the name of your character? (max10): ");
            game.player.name =Console.ReadLine().ToString();
            Console.Clear();
            Console.WriteLine("Set your board, "+game.player.name+".\n");
            game.board.displayBoard();

            //size 1
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Add ship size 1: ");
                game.board.placement();
                game.board.boardUpdate();
            }
            //size 2
            for (int i = 0; i < 3; i++) //3 takie statki
            {
                Console.WriteLine("Add ship size 2: ");
                game.board.placement();
                game.board.boardUpdate();
            }

            // TODO
            // read 'coordinates' >> ex. 2d

            Console.ReadKey();
        }
    }
}
