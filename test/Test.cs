using Temat1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        // jeśli co najmniej jeden przedmiot spełnia ograniczenia
        public void Test1()
        {
            Problem problem = new(5, 1);

            Result result = problem.Solve(50);

            Assert.IsTrue(result.Przedmioty.Count >= 1);
        }

        [TestMethod]
        // jeśli żaden przedmiot się nie mieści
        public void Test2()
        {
            Problem problem = new(5, 1);

            Result result = problem.Solve(0);

            Assert.AreEqual(0, result.Przedmioty.Count);
        }

        [TestMethod]
        // test konkretnej instancji
        public void Test3()
        {
            Problem problem = new(3, 1);

            Result result = problem.Solve(100);

            Assert.IsTrue(result.TotalWartosc > 0);
            Assert.IsTrue(result.TotalWaga > 0);
        }

        [TestMethod]
        // czy algorytm nie przekracza pojemności
        public void Test4()
        {
            Problem problem = new(10, 2);

            int capacity = 15;

            Result result = problem.Solve(capacity);

            Assert.IsTrue(result.TotalWaga <= capacity);
        }

        [TestMethod]
        // wartość nie może być ujemna
        public void Test5()
        {
            Problem problem = new(5, 3);

            Result result = problem.Solve(20);

            Assert.IsTrue(result.TotalWartosc >= 0);
        }
    }
}