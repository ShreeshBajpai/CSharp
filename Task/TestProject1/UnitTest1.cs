using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestProject1
    {
        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void TestFactorial()
            {
                int num = 6;
                int expectedFactorial = 720;

            PrimeAndFactorial obj = new PrimeAndFactorial();
                int actual = obj.factorial(num);

                Assert.AreEqual(actual, expectedFactorial);
            }

            [TestMethod]
            public void TestPrime()
            {
                int num = 30;
                PrimeAndFactorial obj = new PrimeAndFactorial();
                bool actual = obj.prime(num);

                bool expected = true;

                Assert.AreEqual(actual, expected);

            }

            [TestMethod]
            public void TestFactorialLessThanZero()
            {
                int num = -1;
                PrimeAndFactorial obj = new PrimeAndFactorial();
                Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => obj.factorial(num));
            }

            [TestMethod]
            public void TestPrimeLessThanZero()
            {
                int num = -10;
                PrimeAndFactorial obj = new PrimeAndFactorial();
                Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => obj.prime(num));
            }
        }
 }