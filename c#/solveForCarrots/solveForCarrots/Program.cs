
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solveForCarrots
{
    class Program
    {
        static void Main(string[] args)
        {
            String input1 = Console.ReadLine();
            string[] in1Split = input1.Split();

            int n = Convert.ToInt32(in1Split[0]);
            int m = Convert.ToInt32(in1Split[1]);

            for (int i = 0; i < n; i++)
            {
                Console.ReadLine();
            }

            Console.WriteLine(m);
            Console.Read();
        }
    }
}
