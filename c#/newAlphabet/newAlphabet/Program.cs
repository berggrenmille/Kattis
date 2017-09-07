using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            List<char> output = new List<char>();
            foreach(Char c in input)
            {
                switch (c)
                {
                    case 'a':
                        output.Add('@');
                        break;
                    case 'A':
                        output.Add('@');
                        break;
                    case 'b':
                        output.Add('8');
                        break;
                    case 'B':
                        output.Add('8');
                        break;
                    case 'c':
                        output.Add('(');
                        break;
                    case 'C':
                        output.Add('(');
                        break;
                    case 'd':
                        output.Add('|');
                        output.Add(')');
                        break;
                    case 'D':
                        output.Add('|');
                        output.Add(')');
                        break;
                    case 'e':
                        output.Add('3');
                        break;
                    case 'E':
                        output.Add('3');
                        break;
                    case 'f':
                        output.Add('#');
                        break;
                    case 'F':
                        output.Add('#');
                        break;
                    case 'g':
                        output.Add('6');
                        break;
                    case 'G':
                        output.Add('6');
                        break;
                    case 'h':
                        output.Add('[');
                        output.Add('-');
                        output.Add(']');
                        break;
                    case 'H':
                        output.Add('[');
                        output.Add('-');
                        output.Add(']');
                        break;
                    case 'i':
                        output.Add('|');
                        break;
                    case 'I':
                        output.Add('|');
                        break;
                    case 'j':
                        output.Add('_');
                        output.Add('|');
                        break;
                    case 'J':
                        output.Add('_');
                        output.Add('|');
                        break;
                    case 'k':
                        output.Add('|');
                        output.Add('<');
                        break;
                    case 'K':
                        output.Add('|');
                        output.Add('<');
                        break;
                    case 'l':
                        output.Add('1');
                        break;
                    case 'L':
                        output.Add('1');
                        break;
                    case 'm':
                        output.Add('[');
                        output.Add(']');
                        output.Add((char)92);
                        output.Add('/');
                        output.Add('[');
                        output.Add(']');
                        break;
                    case 'M':
                        output.Add('[');
                        output.Add(']');
                        output.Add((char)92);
                        output.Add('/');
                        output.Add('[');
                        output.Add(']');
                        break;
                    case 'n':
                        output.Add('[');
                        output.Add(']');
                        output.Add((char)92);
                        output.Add('[');
                        output.Add(']');
                        break;
                    case 'N':
                        output.Add('[');
                        output.Add(']');
                        output.Add((char)92);
                        output.Add('[');
                        output.Add(']');
                        break;
                    case 'o':
                        output.Add('0');
                        break;
                    case 'O':
                        output.Add('0');
                        break;
                    case 'p':
                        output.Add('|');
                        output.Add('D');
                        break;
                    case 'P':
                        output.Add('|');
                        output.Add('D');
                        break;
                    case 'q':
                        output.Add('(');
                        output.Add(',');
                        output.Add(')');
                        break;
                    case 'Q':
                        output.Add('(');
                        output.Add(',');
                        output.Add(')');
                        break;
                    case 'r':
                        output.Add('|');
                        output.Add('Z');
                        break;
                    case 'R':
                        output.Add('|');
                        output.Add('Z');
                        break;
                    case 's':
                        output.Add('$');
                        break;
                    case 'S':
                        output.Add('$');
                        break;
                    case 't':
                        output.Add('\'');
                        output.Add(']');
                        output.Add('[');
                        output.Add('\'');
                        break;
                    case 'T':
                        output.Add('\'');
                        output.Add(']');
                        output.Add('[');
                        output.Add('\'');
                        break;
                    case 'u':
                        output.Add('|');
                        output.Add('_');
                        output.Add('|');
                        break;
                    case 'U':
                        output.Add('|');
                        output.Add('_');
                        output.Add('|');
                        break;
                    case 'v':
                        output.Add((char)92);
                        output.Add('/');
                        break;
                    case 'V':
                        output.Add((char)92);
                        output.Add('/');
                        break;
                    case 'w':
                        output.Add((char)92);
                        output.Add('/');
                        output.Add((char)92);
                        output.Add('/');
                        break;
                    case 'W':
                        output.Add((char)92);
                        output.Add('/');
                        output.Add((char)92);
                        output.Add('/');
                        break;
                    case 'x':
                        output.Add('}');
                        output.Add('{');
                        break;
                    case 'X':
                        output.Add('}');
                        output.Add('{');
                        break;
                    case 'y':
                        output.Add('`');
                        output.Add('/');
                        break;
                    case 'Y':
                        output.Add('`');
                        output.Add('/');
                        break;
                    case 'z':
                        output.Add('2');
                        break;
                    case 'Z':
                        output.Add('2');
                        break;
                    default:
                        output.Add(c);
                        break;
                }
            }
            string result = new string(output.ToArray());
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
