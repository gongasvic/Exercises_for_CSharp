using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            string[] word;
            string result;
            Console.Write("Write the text: ");
            s = Console.ReadLine();

            Console.Write("Write the word to reverse: ");
            word = Console.ReadLine().Trim().Split();
            while(word.Length > 1 || word[0] == "")
            {
                Console.Write("must be a single word and not empty.\nWrite the word: ");
                word = Console.ReadLine().Trim().Split();
            }
            result = ReverseWord(s, word[0]);
            Console.WriteLine("The output is {0}",result);
            Console.ReadKey();
        }
        public static string ReverseWord(string text, string word) {
            int occurence=0;
            string[] words = text.Split();
            for( int i=0; i < words.Length; i++){
                if(words[i].ToLower() == word.ToLower())
                {
                    char[] charArray = words[i].ToCharArray();
                    Array.Reverse(charArray);
                    words[i] = new string(charArray);
                    occurence++;
                }
            }
            if (occurence == 0)
                Console.WriteLine("The word never occured.");
            return String.Join(" ", words);
        }
    }
}
