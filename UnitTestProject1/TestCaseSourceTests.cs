using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace UnitTestProject1
{
    public class TestCaseSourceTests
    {
        [TestCaseSource(nameof(GetTestCases))]
        public void RunTestCases(IEnumerable<string> value)
        {
            Assert.That(value.First(), Is.EqualTo("banana"));
        }

        public static IEnumerable<TestCaseData> GetTestCases()
        {
            IEnumerable<string> fruits = new[] {"apple", "banana"};

            return fruits
                .GroupBy(s => s)
                .Select(g => new TestCaseData(g));
        }
    }
}
