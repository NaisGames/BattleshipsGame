using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsGame
{
    class GameBoard
    {
        const string shipNoHit = "O";
        const string shipHit = "@";
        const string boardNoHit = " ";
        const string boardHit = "X";
        string legend = "---Legend---   \nO Ship         \n@ Ship with hit\nX Missed Attack\n";
        private const int SIZE = 10;
        //public string[,] clearBoard = new string[SIZE+1,SIZE+2];
        public string[,] emptyBoard = { { "  |","A|", "B|","C|","D|","E|","F|","G|","H|","I|","J|" }, 
            {" 1|"," |"," |"," |"," |"," |"," |"," |"," |"," |"," |"}, 
            {" 2|"," |"," |"," |"," |"," |"," |"," |"," |"," |"," |"},
            {" 3|"," |"," |"," |"," |"," |"," |"," |"," |"," |"," |"},
            {" 4|"," |"," |"," |"," |"," |"," |"," |"," |"," |"," |"},
            {" 5|"," |"," |"," |"," |"," |"," |"," |"," |"," |"," |"},
            {" 6|"," |"," |"," |"," |"," |"," |"," |"," |"," |"," |"},
            {" 7|"," |"," |"," |"," |"," |"," |"," |"," |"," |"," |"},
            {" 8|"," |"," |"," |"," |"," |"," |"," |"," |"," |"," |"},
            {" 9|"," |"," |"," |"," |"," |"," |"," |"," |"," |"," |"},
            {"10|"," |"," |"," |"," |"," |"," |"," |"," |"," |"," |"},
        };

        public int rowCoord;
        public int colCoord;


        public void displayBoard()
        {
            for (int row = 0; row < 11; row++)
            {
                for (int col = 0; col < 11; col++)
                {
                    Console.Write(emptyBoard[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n"+legend);
            Console.WriteLine("Enter ship placemnets (ex. \"1d 2d\" is a ship size 2)\n");
        }

        public void placement() {
            string place = Console.ReadLine().ToString();
            try {
                rowCoord = Convert.ToInt32(place.Substring(0, 1));
            }
            catch (Exception e) { Console.WriteLine(e.Message); }

            switch (place.Substring(1, 1))
            {
                case "A":
                case "a":
                    colCoord = 1;
                    break;
                case "B":
                case "b":
                    colCoord = 2;
                    break;
            }
            
        }

        public void boardUpdate() {
            Console.Clear();
            emptyBoard[rowCoord, colCoord] = "0|";
            displayBoard();
        }
        
    }
}
