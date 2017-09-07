using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    class Program
    {
        static void Main(string[] args)
        {
            String input1 = Console.ReadLine();
            String input2 = Console.ReadLine();
            String[] arr1 = input1.Split();
            String[] arr2 = new string[3];

            List<int> ints = new List<int>();
            ints.Add(Int32.Parse(arr1[0]));
            ints.Add(Int32.Parse(arr1[1]));
            ints.Add(Int32.Parse(arr1[2]));
            ints.Sort();          

            arr2[0] = input2[0].ToString();
            arr2[1] = input2[1].ToString();
            arr2[2] = input2[2].ToString();


            for (int i = 0; i < 3; i++)
            {
                switch (arr2[i])
                {
                    case "A":
                        Console.Write(ints[0]);
                        Console.Write(" ");
                        break;

                    case "B":
                        Console.Write(ints[1]);
                        Console.Write(" ");
                        break;

                    case "C":
                        Console.Write(ints[2]);
                        Console.Write(" ");
                        break;

                    default:
                        break;
                }
            }
            Console.Read();

            
            

            
        }
    }
}
