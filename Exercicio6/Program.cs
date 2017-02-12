using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int cipher;
            string toCipher;
            string ciphered;

            Console.Write("Write string to cipher: ");

            toCipher = Console.ReadLine();
            Console.Write("Write shift size, value between 1 and 23: ");

            while (!int.TryParse(Console.ReadLine(), out cipher) && (int.Parse(Console.ReadLine()) < 24))
                Console.Write("ERROR: Must be a number between 1 and 23\nWrite value: ");

            ciphered = Cipher(toCipher, cipher);
            Console.WriteLine(ciphered);
            Console.ReadKey();
        }

        public static string Cipher(string text, int shift)
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
                    result += (char)(i + shift);
            }
            return result;
        }
    }
}
