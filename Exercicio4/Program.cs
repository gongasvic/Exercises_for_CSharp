using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y ;
            Console.Write("Write value: ");
            string[] s = Console.ReadLine().Split();
            try
            {
                while (!(int.TryParse(s[0], out x) && int.TryParse(s[1], out y)))
                {
                    Console.Write("ERROR: Must be numbers\nWrite value: ");
                    s = Console.ReadLine().Split();
                }
            }catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("ERROR: Must be 2 numbers, please re-run");
                throw e;
            }
            SolA(x, y);
            SolB(x, y);
        }

        private static void SolA(int x, int y)
        {
            y -= x;// y= y-x
            x += y;// x = x + y(antigo) -x 
            // x = y(antigo)
            y = -1 * (y - x);// y= -1*(y(antigo)-x(antigo)-x(antigo)-y(antigo)+x(antigo))
            //y = x(antigo)
            Console.Write("Solução A: ");
            Console.Write("" + x + " " + y);
        }
        private static void SolB(int x, int y)
        {
            // googled it, had no idea
            x = x^y;
            y = y^x;
            x = x^y;
            Console.Write("\nSolução B: ");
            Console.Write("" + x + " " + y);
            Console.ReadKey();
        }
    }
}
