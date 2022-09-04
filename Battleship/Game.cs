
using System;
namespace Battleship
{
    public class Game
    {
        Random cordinates = new Random();
        Char[,] grid = new char[10, 10];
        int BattleshipHits = 0;
        int Miss = 0;
        int DestroyerHits = 0;
       
        public void GamePlay()
        {

            
        try
            {
                int x = 0;
                int y = 0;
                int input;
                Console.WriteLine("Enter X Cordinate");
                string line = Console.ReadLine();
                input = Int32.Parse(line);
            
                x = input;
                
                Console.WriteLine("Enter Y cordinate");
                line = Console.ReadLine();
                input = Int32.Parse(line);
                    y = input;
                
            
                if (grid[x,y] == 'B')
                {
                    IsHitShot(x, y);
                    Console.Clear();
                    Console.WriteLine("Hit!\r\n");
                    BattleshipHits++;
                }
                else if (grid[x, y] == 'D')
                {
                    IsHitShot(x, y);
                    Console.Clear();
                    Console.WriteLine("Hit!\r\n");
                    DestroyerHits++;
                }
                else
                {
                    IsMissShot(x, y);
                    Console.Clear();
                    Console.WriteLine("Miss!\r\n");
                    Miss++;
                }
            }
            catch

            {
                Console.Clear();
                Console.WriteLine("Error: Please enter numbers between 0 and 9.");
            }
            if (BattleshipHitCount() == 5)
            {
                Console.WriteLine("Buttleship sunk");
               
            }
            if (DestroyerHitCount() == 4)
            {
                Console.WriteLine("Destroyer sunk");
                
            }
            Console.ReadKey();
            Console.Clear();
        }

       

        public void PutBattleship()
        {
            int x = cordinates.Next(5);
            int y = cordinates.Next(4);
            int count = 0;
                while (count < 5)
                {
                    SetBattleship(x, y);
                    x++;
                    count++;
                }
            
        }

        public void PutDestroyers()
        {
                int x = cordinates.Next(4);
                int y = cordinates.Next(5,6);
                int i = cordinates.Next(5,9);
                int j = cordinates.Next(5, 6);
                int count = 0;
                while (count < 4)
                {
                    SetDestroyers(x, y);
                    SetDestroyers(i, j);
                    y++;
                    j++;
                    count++;
                }
            
        }
      

        public char SetBattleship(int x, int y)
        {
            return grid[x, y] = 'B';
        }
        public char SetDestroyers(int x, int y)
        {
        
            return grid[x, y] = 'D';
        }
        public char IsHitShot(int x, int y)
        {
            return grid[x, y] = 'H';
        }

        public char IsMissShot(int x, int y)
        {
            if (grid[x,y] == 'H')
            {
                return 'H';
            }
            return grid[x, y] = 'M';
        }
      
        public int HitsCount()
        {
            return BattleshipHits + DestroyerHits;
        }
        public int MissCount()
        {
            return Miss;
        }
        private int BattleshipHitCount()
        {
            return BattleshipHits;
        }
        private int DestroyerHitCount()
        {
            return DestroyerHits;
        }

        public void DisplayGrid()
        {
            Console.WriteLine(" |0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine(" +__________");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + "|");
                for (int J = 0; J < 10; J++)
                {
           
                        Console.Write(grid[J, i] + ".");
             
                }
                Console.WriteLine();
            }
        }
    }
}

 

     