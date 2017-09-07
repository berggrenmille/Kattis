using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevBinary
{ 

    class Program
    {
        static void Main(string[] args)
        {
            int input = Int32.Parse(Console.ReadLine());
            String binary = Convert.ToString(input, 2);
            binary = ReverseString(binary);
            int output = Convert.ToInt32(binary, 2);
            Console.WriteLine(output);
            Console.Read();
        }

        static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
