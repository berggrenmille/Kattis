using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pot
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            List<string> sList = new List<string>();
            List<short> powList = new List<short>();
            long[] numArr = new long[n];
            for (int i = 0; i < n; i++)
            {
                sList.Add(Console.ReadLine());
                string temp = sList[i];
                char pow = temp[temp.Length - 1];
                powList.Add(Convert.ToInt16(pow.ToString().Trim()));

                sList[i] = sList[i].Remove(sList[i].Length - 1, 1);
                numArr[i] = Convert.ToInt64(sList[i]);
            }
            long sum = 0;
            for (int j = 0; j < numArr.Length; j++)
            {
                sum += Convert.ToInt64(Math.Pow(Convert.ToDouble(numArr[j]), Convert.ToDouble(powList[j])));
            }
            Console.WriteLine(sum);
            Console.Read();
        }
    }
}





