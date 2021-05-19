using System;
using System.Collections.Generic;
using System.IO;

namespace AdventCodeDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines("../../../input.txt");
            Console.WriteLine(ExpenseCalculate2020(file));
        }
        static int ExpenseCalculate2020(string[] input)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            int key = 0;
            foreach (string number in input)
            {
                dictionary.Add(key, Convert.ToInt32(number));
                key++;
            }
            for (int i = 0; i < dictionary.Count; i++)
            {
                int current = dictionary.GetValueOrDefault(i);
                for (int j = i + 1; j < dictionary.Count; j++)
                {
                    if(current + dictionary.GetValueOrDefault(j) == 2020)
                    {
                        return current * dictionary.GetValueOrDefault(j);
                    }
                }
            }
            return 0;
        }
    }
}
