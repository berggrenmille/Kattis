using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aaah
{
    class Program
    {
        static void Main(string[] args)
        {
            String input1 = Console.ReadLine();
            String input2 = Console.ReadLine();

            int a = 0;
            int b = 0;


            for (int i = 0; i < input1.Length; i++)
            {
                if(input1[i] == 'a')
                {
                    a++;
                }

            }

            for (int j = 0; j  < input2.Length; j ++)
            {
                if (input2[j] == 'a')
                {
                    b++;
                }

            }

            if (a >= b)
            {
                Console.WriteLine("go");
            }else
            {
                Console.WriteLine("no");
            }
            Console.Read();
        }
    }
}
