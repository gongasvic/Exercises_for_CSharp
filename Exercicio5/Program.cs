using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            long x;
            string binary;
            Console.Write("Write value: ");

            while (!long.TryParse(Console.ReadLine(), out x))
                Console.Write("ERROR: Must be a number\nWrite value: ");


            binary = ToBinary(x);
            Console.Write(binary);
            Console.ReadKey();

        }

        private static string ToBinary(long x)
        {
            string final_x = "";
            char[] charArray;
            while (x > 0)
            {
                final_x += (x % 2).ToString();
                x /= 2;
            }

            charArray = final_x.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
