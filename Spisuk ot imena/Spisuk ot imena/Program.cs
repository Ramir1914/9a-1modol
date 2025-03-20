using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spisuk_ot_imena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi imena: ");
            Console.Write(" - ");
            string[] names = Console.ReadLine().Split(' ');
            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.Write(names[i]);
                if (i > 0)
                {
                    Console.Write("; ");
                }
            }
        }
    }
}
