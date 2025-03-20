using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spisuk_ot_chetni_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi chisla: ");
            Console.Write(" - ");
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", evenNumbers));
        }
    }
}
