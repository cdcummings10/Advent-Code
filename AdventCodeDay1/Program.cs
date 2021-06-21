﻿using System;
using System.Collections.Generic;
using System.IO;

namespace AdventCodeDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines("../../../input.txt");
            Expenses expenses = new Expenses();
            Dictionary<int, int> dictionary = CreateExpenseDictionary(file);
            Dictionary<int, int> dictionary2 = expenses.CreateExpenseDictionary(file);
            Console.WriteLine(ExpenseCalculate2020(dictionary));
            Console.WriteLine(expenses.ExpenseCalculate2020(dictionary2));
            Console.WriteLine(ExpenseCalculate2020ThreeNumbers(dictionary));
            Console.WriteLine(expenses.ExpenseCalculate2020ThreeNumbers(dictionary2));
            
        }
        static Dictionary<int, int> CreateExpenseDictionary(string[] input)
        {
            if(input == null || input.Length == 0)
            {
                return null;
            }
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            int key = 0;
            foreach (string number in input)
            {
                dictionary.Add(key, Convert.ToInt32(number));
                key++;
            }
            return dictionary;
        }
        static int ExpenseCalculate2020(Dictionary<int, int> dictionary)
        {
            if (dictionary.Count == 0 || dictionary == null)
            {
                return 0;
            }
            for (int i = 0; i < dictionary.Count; i++)
            {
                int current = dictionary.GetValueOrDefault(i);
                for (int j = i + 1; j < dictionary.Count; j++)
                {
                    if (current + dictionary.GetValueOrDefault(j) == 2020)
                    {
                        return current * dictionary.GetValueOrDefault(j);
                    }
                }
            }
            return 0;
        }
        static int ExpenseCalculate2020ThreeNumbers(Dictionary<int, int> dictionary)
        {
            if (dictionary.Count == 0 || dictionary == null)
            {
                return 0;
            }
            for (int i = 0; i < dictionary.Count; i++)
            {
                int current = dictionary.GetValueOrDefault(i);
                for (int j = i + 1; j < dictionary.Count; j++)
                {
                    int second = dictionary.GetValueOrDefault(j);
                    for (int k = j + 1; k < dictionary.Count; k++)
                    {
                        int third = dictionary.GetValueOrDefault(k);
                        if((current + second + third) == 2020)
                        {
                            return current * second * third;
                        }
                    }
                }
            }
            return 0;
        }
    }
}
