using System;
using System.Linq;

namespace Goal_Parser_Interpretation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Interpret("(al)G(al)()()G(al)"));
        }
        static string Interpret(string command)
        {
            string[] arrCmd = command.ToCharArray().Select(c => c.ToString()).ToArray();
            string[] newStr = new string[command.Length];
            int i = 0, j = 0;
            do
            {
                if (arrCmd[i] == "G") { newStr[j] = "G"; j++; i++; continue; }
                else if (arrCmd[i] == "(" && arrCmd[i + 1] == ")") { newStr[j] = "o"; j++; i += 2; continue; }
                else if (arrCmd[i + 1] == "a") { newStr[j] = "al"; j++; i += 4; continue; }
            } while (i < arrCmd.Length);
            return string.Join("", newStr);
        }
    }
}