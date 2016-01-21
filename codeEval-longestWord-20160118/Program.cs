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
            string line = "fantassdfsdfi lines out dishes";
            string[] allWords = line.Split(' ');

            int maxWord = allWords[0].Length;
           

            //for (int i = 1; i < allWords.Length; i++)
            //{
            //    int maxWord = allWords[0].Length;
            //    if (allWords[i].Length > maxWord)
            //    {
            //        maxWord = allWords[i].Length;

            //    }


            //    if (i == allWords.Length)
            //    {
            //        Console.WriteLine(allWords[i]);
            //    }
            //}





            //string word = "hamburger";
            //Console.WriteLine(word.Length);

            Console.ReadKey();
            
        }
    }
}
