using System;

namespace Accelerate
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Player player1 = new Player(Difficulty.Easy);
            Player player2 = new Player(Difficulty.Medium);
            Player player3 = new Player(Difficulty.Hard);
        }
    }
    /*
Easy => "You have 3 minutes 45 seconds"
Medium = > "You have 3 minutes 20 seconds"
Hard => "You have 3 minutes"
*/

    class Player
    {
        public Player(Difficulty x)
        {
            //your code goes here
            switch (x)
            {
                case (int)x.Easy:
                    Console.WriteLine("You have 3 minutes 45 seconds");
                    break;
                case (int)x.Medium:
                    Console.WriteLine("You have 3 minutes 20 seconds");
                    break;
                case (int)x.Hard:
                    Console.WriteLine("You have 3 minutes");
                    break;
            }
        }
    }
    enum Difficulty
    {
        Easy,
        Medium,
        Hard
    };
}
