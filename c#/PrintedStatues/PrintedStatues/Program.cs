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
            int countDays = 0;

            if (n == 1)
                countDays = 1;
            else if (n % 2 == 0)
            {
                numOfPrinters += (n / 2)-1;
                countDays += (n / 2)-1;
                if(n % numOfPrinters == 0)
                    countDays += n / numOfPrinters;
                else
                {
                    countDays += (n / numOfPrinters) + 1;
                }
                
            }
            else
            {
                numOfPrinters += (n / 2);
                countDays += (n / 2);
                if (n % numOfPrinters == 0)
                    countDays += n / numOfPrinters;
                else
                {
                    countDays += (n / numOfPrinters) + 1;
                }
            }

            

            Console.WriteLine(countDays);
            Console.Read();

        }
    }
}
