using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yoda
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int length1 = input1.Length;
            int length2 = input2.Length;

            int n;

            if(length1 > length2)
            {
                n = length2;
            }
            else
            {
                n = length1;
            }

            for (int i = 0; i < n; i++)
            {
                int temp1 = input1[length1 - i - 1];
                int temp2 = input2[length2 - i - 1];

                if (temp1 > temp2)
                {
                    input2 = input2.Remove(length2 - i - 1, 1);
                    input2 = input2.Insert(length2 - i - 1, " ");
                }else if(temp1 < temp2)
                {
                    input1 = input1.Remove(length1 - i - 1, 1);
                    input1 = input1.Insert(length1 - i - 1, " ");
                }                
            }

            input1 = input1.Replace(" ", string.Empty);
            input2 = input2.Replace(" ", string.Empty);

            string result1;
            string result2;

            if (input1 == "")
            {
                result1 = "YODA";
            }
            else
            {
                result1 = new string(Convert.ToInt32(input1).ToString().ToCharArray());
            }

            if (input2 == "")
            {
                result2 = "YODA";
            }else
            {
                result2 = new string(Convert.ToInt32(input2).ToString().ToCharArray());
            }

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.Read();
        }
    }
}
