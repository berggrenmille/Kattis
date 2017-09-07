using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptographers
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = Console.ReadLine();
            Char[] textArr = text.ToCharArray();
            int days = 0;

            int tempInt = 1;
            for (int i = 0; i < text.Length; i++)
            {
                if(tempInt == 1)
                {
                    if(textArr[i] != 'P')
                    {
                        days++;
                    }
                }else if(tempInt == 2)
                {
                    if(textArr[i] != 'E')
                    {
                        days++;
                    }
                }
                else if (tempInt == 3)
                {
                    if (textArr[i] != 'R')
                    {
                        days++;
                        tempInt = 0;
                    }else
                    {
                        tempInt = 0;
                    }
                }
                tempInt++;
            }
            Console.WriteLine(days);
            Console.Read();
        }
    }
}
