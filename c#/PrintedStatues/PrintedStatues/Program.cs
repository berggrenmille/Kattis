using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintedStatues
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int numOfPrinters = 1;
            int n = Int32.Parse(Console.ReadLine());
            int countDays = 1;

            while(numOfPrinters < n)
            {
                numOfPrinters = (int)Math.Pow(2, countDays);
                countDays++;
            }

            Console.WriteLine(countDays);
            Console.Read();

        }
    }
}
