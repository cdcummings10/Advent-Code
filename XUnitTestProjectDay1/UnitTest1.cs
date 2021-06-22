using AdventCodeDay1;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProjectDay1
{
    public class UnitTest1
    {
        Expenses expenses = new Expenses();
        [Fact]
        public void TestNullCreateDictionary()
        {
            Dictionary<int, int> dictionary = expenses.CreateExpenseDictionary(null);
            Assert.Null(dictionary);
        }
    }
}
