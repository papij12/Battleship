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
            Console.WriteLine(" |0123456789");
            Console.WriteLine(" +__________");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + "|");
                for (int J = 0; J < 10; J++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
        }
    }
}

