using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathsMania.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public static void Main()
        {
            for (int i = 0; i < 1000; i++)
            {
                var randomNumber = new Random().Next(0, 4);
                Console.WriteLine(randomNumber);
            }
            Console.ReadLine();

        }
        [TestMethod]
        public void TestMethod1()
        {
            var randomNumber = new Random().Next(0, 4);

            Assert.IsTrue(randomNumber < 4);
            Assert.IsTrue(randomNumber >= 0);
        }

        [TestMethod]
        public void TestRandominiseArrayContents()
        {
            var code = new Code();

            int[] originalOrder = { 1, 2, 3, 4 };
            int[] order = { 1, 2, 3, 4 };

            code.RandominiseArrayContents(order, 20);

            Assert.IsTrue(
                originalOrder[0] != order[0] ||
                originalOrder[1] != order[1] ||
                originalOrder[2] != order[2] ||
                originalOrder[3] != order[3]
                );


        }


    }
}
