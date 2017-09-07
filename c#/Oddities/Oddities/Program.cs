using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oddities
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Int32.Parse(Console.ReadLine());
            }

            for (int j = 0; j < n; j++)
            {
                if(numbers[j]%2 == 0)
                {
                    Console.WriteLine(numbers[j] + " is even");
                }else
                {
                    Console.WriteLine(numbers[j] + " is odd");
                }
            }
            Console.Read();
        }
    }
}
