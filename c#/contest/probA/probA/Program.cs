using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probA
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                int g = Int32.Parse(Console.ReadLine());
                string cString = Console.ReadLine();
                string[] cArr = cString.Split(' ');

                
                ILookup<int, String> dicta = cArr.ToLookup(pair => g);
             

                foreach (string k in dicta[0])
                {
                    Console.WriteLine(k);
                }
                
                Console.Read();


            }
        }
    }
}
