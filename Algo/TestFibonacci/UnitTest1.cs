using System.Globalization;

namespace TestFibonacci
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFiboBoucle()
        {
            string fibo = Fibonacci.Program.FibonacciBoucle(5);
            Assert.AreEqual(fibo, "\n0\n1\n1\n2\n3");
        }

        [TestMethod]
        public void TestFiboRecursiveString()
        {
            string fibo = Fibonacci.Program.FibonacciRecursiveString(5);
            Assert.AreEqual(fibo, "\n0\n1\n1\n2\n3");
        }

        [TestMethod]
        public void TestFiboRecursiveInt1()
        {
            int fibo = Fibonacci.Program.FibonacciRecursiveInt(0);
            Assert.AreEqual(fibo, -1);
        }

        [TestMethod]
        public void TestFiboRecursiveInt2()
        {
            int fibo = Fibonacci.Program.FibonacciRecursiveInt(1);
            Assert.AreEqual(fibo, 0);
        }

        [TestMethod]
        public void TestFiboRecursiveInt3()
        {
            int fibo = Fibonacci.Program.FibonacciRecursiveInt(5);
            Assert.AreEqual(fibo, 3);
        }

        [TestMethod]
        public void TestFiboTab()
        {
            long[] fibo = Fibonacci.Program.FibonacciTab(5);
            long[] result = { 0, 1, 1, 2, 3 };

            bool isEqual = fibo.SequenceEqual(result);
            Assert.IsTrue(isEqual);
        }
    }
}