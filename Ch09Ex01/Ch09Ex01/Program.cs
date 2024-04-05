using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch09Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] hillHeight = { { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6 }, { 4, 5, 6, 7 }, { 5, 6, 7, 8 } };

            Console.WriteLine("Below is the complete elements of hillHeight array:");
            Console.WriteLine("-----------------");
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write($"| {hillHeight[r, c]} ");
                }
                Console.Write("|\n-----------------\n");
            }

            Console.WriteLine("Therefore, the array indices of hillHeight will have the following value:\n");
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.WriteLine($"hillHeight[{r},{c}] contains value of: {hillHeight[r, c]}");
                }
            }

            Console.WriteLine("\nNow, let's identify specific value from array hillHeight..");
            int x = 0, y = 0;
            Console.Write("Please enter the array index 'x' : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the array index 'y' : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nThe element of hillHeight[{x},{y}] is => {hillHeight[x, y]}");
            Console.WriteLine("Congratulations! Press any key to exit...");
            Console.ReadKey();
        }
    }
}
