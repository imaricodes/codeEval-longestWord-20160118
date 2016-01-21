using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeEval_longestWord_20160118
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "tragic lines buzzwords out dishes difficult";
            string[] allWords = line.Split(' ');

            //int maxWord = allWords[0].Length;

            int longestWord = Int32.MinValue;
            int len = allWords.Length; //number of items in allWords array
            

            for (int i = 0; i < len; i ++)
            {
                if (allWords[i].Length > longestWord)
                {
                    longestWord = allWords[i].Length;
                    //Console.WriteLine(allWords[i]);
                }
            }

            for (int j = 0; j < allWords.Length; j ++)
            {
                if (allWords[j].Length == longestWord)
                {
                    Console.WriteLine(allWords[j]);
                    break;
                }
            }

            Console.WriteLine("End of Program");

            Console.ReadKey();
            
        }
    }
}
