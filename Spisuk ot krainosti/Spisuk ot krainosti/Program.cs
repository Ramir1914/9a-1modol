using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spisuk_ot_krainosti
{
    class Program
    {
        static void Main(string[] args)
            //Въведете списък от цели числа и изведете тези от тях, които са равни на минималния или максималнияелемент.
        {
            Console.WriteLine("Vuvedi chisla:  ");
            Console.Write(" - ");
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int min = numbers.Min();
            int max = numbers.Max();
            List<int> result = new List<int>();
            foreach (var number in numbers)
            {
                if (number == min || number == max)
                {
                    result.Add(number);
                }
            }
            Console.WriteLine(string.Join(" , ", result));
        }
    }
}
