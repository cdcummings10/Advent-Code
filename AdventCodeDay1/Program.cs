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
            Expenses expenses = new Expenses();
            Dictionary<int, int> dictionary1 = expenses.CreateExpenseDictionary(file);
            Console.WriteLine(expenses.ExpenseCalculate2020(dictionary1));
            Console.WriteLine(expenses.ExpenseCalculate2020ThreeNumbers(dictionary1));
        }
 
    }
}
