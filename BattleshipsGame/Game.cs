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
            game.board.placement();
            // TODO
            // read 'coordinates' >> ex. 2d
            game.board.boardUpdate();

            Console.ReadKey();
        }
    }
}
