using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                string[] inputArr = Console.ReadLine().Split();
                for (int j = 0; j < 4; j++)
                {
                    grid[i, j] = Convert.ToInt32(inputArr[j]);
                }
            }
            int move = Convert.ToInt32(Console.ReadLine());
            int movableBricks = 0;  
            do
            {
                switch (move)
                {
                    case 0: //left move
                        for (int y = 0; y < 4; y++)
                        {
                            for (int x = 0; x < 4; x++)
                            {

                            }
                        }
                        break;
                    case 1: //up
                        break;
                    case 2: //right
                        break;
                    case 3: //down
                        break;

                    default:
                        break;
                }
            } while (movableBricks != 0);  
        }
    }
}
