using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemD
{
    class Program
    {
        //after each wowel a p+vowel is added
        static void Main(string[] args)
        {
            Char[] vowels = new Char[] {'a', 'e', 'i', 'o', 'u'};

            String input = Console.ReadLine();
            Char[] charList = input.ToCharArray();
            

            List<char> index = new List<char>();

            bool isEncoded = false;
            for (int i = 0; i < charList.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (charList[i] == vowels[j])
                    {
                        isEncoded = true;
                    }
                }
                int removed = 0;
                if (i < removed)
                {
                    if (charList[i + 1] == ' ')
                    {
                        index.Add(charList[i]);
                    }
                }
                
                //check for fakes
                if (isEncoded)
                {
                    if (i < charList.Length)
                    {
                        
                        if(charList[i+1] == 'p' && charList [i] == charList[i + 2])
                        {
                            charList[i+1] = ' ';
                            charList[i+2] = ' ';
                            removed += 2;
                                                   
                        }
                    }
                }
                isEncoded = false;
            }
            string result = new string(charList);


            int t = 0;
            result = result.Replace(" ", "");
            foreach (char c in index)
            {
                int a = result.ElementAt(c);
                result = result.Insert(a + 1, " ");
                Console.WriteLine(c);
            }
            
            

            Console.WriteLine(result);
            
            Console.Read();
        }
    }
}
