using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArr = input.Split();

            int r1 = Convert.ToInt32(inputArr[0]);
            int s = Convert.ToInt32(inputArr[1]);

            int r2 = s * 2 - r1;
            Console.WriteLine(r2);
            Console.Read();
        }
    }
}
