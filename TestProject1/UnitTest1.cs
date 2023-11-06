using NUnit.Framework;

namespace TestProject1
{
    public class MathSolverTests
    {
        [Test]
        [TestCase("5+5", 10)]
        [TestCase("5-5", 0)]
        [TestCase("5*5", 25)]
        [TestCase("5%5", 1)]
        public void normalusecase(string expression, double result)
        {
            if (result == Evaluate.Eval(expression))
            {
                Assert.Pass();
            }
            else { Assert.Fail(); }
        }
    }
}