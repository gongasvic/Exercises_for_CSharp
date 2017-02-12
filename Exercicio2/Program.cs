using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        public static int Fatorial(int n)
        {
            if (n == 1 || n == 0)
                return 1;
            else
                return n*Fatorial(n - 1);
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Write value: ");
            while (!int.TryParse(Console.ReadLine(), out n))
                Console.Write("ERROR: Must be a number\nWrite value: ");
            n = Fatorial(n);
            Console.WriteLine(n);
            Console.ReadKey();
        }
        
    }
}
