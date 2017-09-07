using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemB
{
    class Program
    {
        //knapptryck
        //tryck 1 - A
        //tryck 2 - B
        //tryck 3 - Ba
        // BAB, BABBA
        


        static void Main(string[] args)
        {
            int k = Int32.Parse(Console.ReadLine());

            int a = 0;
            int b = 0;

            List<String> sList = new List<string>();

            for (int i = 0; i < k; i++)
            {
                sList[i] = buttonPress(i);
            }
            foreach(String s in sList)
            {
                Console.WriteLine(s);
            }
            Console.Read();

            
        }

        static String buttonPress(int n)
        {
            if (n == 1)
            {
                return ("B");
            }
            else if (n == 0)
            {
                return ("A");
            }
            else
            {
                return (buttonPress(n - 1));
            }
        }
    }
}
