using System;
using System.Collections.Generic;
using System.Text;

namespace AdventCodeDay1
{
    public class Expenses
    {
        public string Test { get; set; } = "Test";
        public Dictionary<int, int> CreateExpenseDictionary(string[] input)
        {
            if (input == null || input.Length == 0)
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
        public int ExpenseCalculate2020(Dictionary<int, int> dictionary)
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
        public int ExpenseCalculate2020ThreeNumbers(Dictionary<int, int> dictionary)
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
                        if ((current + second + third) == 2020)
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
