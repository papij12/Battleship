using System;


namespace Battleship
{
    class Program
    {
        public static void Main(string[] args)
        {

            Game g = new Game();
            Program p = new Program();
            
            g.PutBattleship();
            g.PutDestroyers();
            Console.WriteLine("BATTLSHIP 1");
            Console.WriteLine("-----------\n");
            p.BoardOfTheGame();
   
            while (g.HitsCount() < 13)
                {
                    g.GamePlay();
                    p.BoardOfTheGame();

                }
                Console.Clear();
                Console.WriteLine("Game Over");

                g.DisplayGrid();
                Console.ReadLine();
          
        }
        private void BoardOfTheGame()
        {
            Console.WriteLine("  0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine(" +__________");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + "|");
                for (int J = 0; J < 10; J++)
                {
                    Console.Write(". ");
                }
                Console.WriteLine();
            }
        }
    }
}

