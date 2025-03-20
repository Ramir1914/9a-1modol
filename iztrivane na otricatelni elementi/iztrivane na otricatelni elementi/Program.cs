﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iztrivane_na_otricatelni_elementi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi otricatelni i polojitelni chisla: ");
            Console.Write(" - ");
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                    result.Add(numbers[i]);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                result.Reverse();
                Console.WriteLine(string.Join(" , ", result));
            }

        }
    }
}
