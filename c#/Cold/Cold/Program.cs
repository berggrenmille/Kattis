using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cold
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[] temp = new int[n];
            int t = 0;

            String inTemp = Console.ReadLine();

            String[] temps = inTemp.Split();

            for (int i = 0; i < temps.Length; i++)
            {
                temp[i] = Int32.Parse(temps[i]);
            }

            for (int a = 0; a < n; a++)
            {
                if(temp[a] < 0)
                {
                    t += 1;
                }
            }
            Console.WriteLine(t);
            Console.Read();
        }
    }
}
