using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backspace
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputArr = input.ToCharArray();
            while(inputArr.Contains('<'))
            {
                for (int i = 0; i < inputArr.Length; i++)
                {
                    if (inputArr[i] == '<')
                    {
                        inputArr[i] = ' ';
                        inputArr[i - 1] = ' ';
                        inputArr = (new string(inputArr)).Trim(' ').ToCharArray();
                        Console.WriteLine(new string(inputArr));
                        break;
                    }
                    
                }
            }
            Console.WriteLine(new string(inputArr));
            Console.Read();
        }
    }
}
