using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TaskFibonachi;

namespace TaskFibonachi
{
    [TestFixture]
    public class Class1
    {
        [TestCase(2, new int[] { 0, 1, 1 })]
        [TestCase(4, new int[] { 0, 1, 1, 2, 3 })]
        [TestCase(6, new int[] { 0, 1, 1, 2, 3, 5, 8 })]
        [TestCase(8, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21 })]
        [TestCase(10, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 })]
        public void Fibonachi_Tests(int num, int[] expRes)
        {
            int[] Fib = Fibonachi.Generator(num);
            Assert.AreEqual(expRes, Fib);
        }

    }
}
