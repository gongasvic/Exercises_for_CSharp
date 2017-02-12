using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int key;
            string toDecipher;
            string deciphered;

            Console.Write("Write string to decipher: ");

            toDecipher = Console.ReadLine();
            Console.Write("Write shift size, value between 1 and 23: ");

            while (!int.TryParse(Console.ReadLine(), out key) && (int.Parse(Console.ReadLine()) < 24))
                Console.Write("ERROR: Must be a number between 1 and 23\nWrite value: ");

            deciphered = Decipher(toDecipher, key);
            Console.WriteLine(deciphered);
            Console.ReadKey();
        }

        public static string Decipher(string text, int shift)
        {
            string result = "";
            int number;
            foreach (char i in text)
            {
                if (i == ' ')
                    result += i;
                else if (int.TryParse("" + i, out number))
                    result += number;
                else
                    result += (char)(i - shift);
            }
            return result;
        }
    }
}


