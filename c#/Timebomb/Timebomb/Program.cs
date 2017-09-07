using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timebomb
{
    class Program
    {
        static void Main(string[] args)
        { 
            String input = Console.ReadLine();
            int rows = input.Length / 5;

            char[,] matrix = new char[rows,5];

            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    matrix[i, j] = input[count];
                    count++;
                }

            }


            
        }
    }
}
