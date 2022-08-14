using System;

namespace Battleship
{
   public class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int Add(string numbers)
        {
          
            if (numbers == "")  

            return 0;

            char[] delimiter = { ',', '!','[','*',']' };

           string[] result = numbers.Split(delimiter,StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;

            foreach (string value in result)
            {
               if (int.Parse(value) > 0 && int.Parse(value) <= 1000)

                sum += int.Parse(value);
            }   
            
            return sum;

        }
    }
}
