using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spavanac
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArr = input.Split(' ');
            int h = Int32.Parse(inputArr[0]);
            int m = Int32.Parse(inputArr[1]);

            if(m >= 45)
            {
                m -= 45;
            }else
            {
                h--;
                m = 60 - (45 - m);
            }

            if(h == -1)
            {
                h = 23;
            }else if(h == 24)
            {
                h = 0;
            }else
            {
                h = h;
            }
            Console.WriteLine(h + " " + m);
            Console.Read();

        }
        
    }
}
