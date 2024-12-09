using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smqtane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi edno tricifreno chislo");
            int a=int.Parse(Console.ReadLine());
            int s, d, e;
            s = a / 100;
            d = s %100/10;
            e = a %100%10;
            Console.WriteLine($"s{s},d= {d},e= {e}");

               
            



        }
    }
}
