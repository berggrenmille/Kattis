using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVeBeenEverywhereMan
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Int32.Parse(Console.ReadLine());

            List<int> ans = new List<int>();
            for (int i = 0; i < t; i++)
            {
                int n = Int32.Parse(Console.ReadLine());
                List<String> cities = new List<string>();
                for (int j = 0; j < n; j++)
                {
                    string s = Console.ReadLine();
                    if (cities.Contains(s) == false)
                    {
                        cities.Add(s);
                    }
                }
                ans.Add(cities.Count);
                cities.Clear();
            }

            for (int l = 0;  l < ans.Count;  l++)
            {
                Console.WriteLine(ans[l]);
            }
            Console.Read();
        }
    }
}
