using NUnit.Framework;
using PierwiastkiKwadratowa;

namespace PierwiastkiKwadratowaTest
{
    [TestFixture]
    public class QuadraticEquationSolverTests
    {
        [Test]
        public void TestDeltaGreaterThanZero()
        {
            //Given
            double a = 2;
            double b = 3; 
            double c = 1;
            // Arrange
            QuadraticEquationSolver solver = new QuadraticEquationSolver();

            // Result
            string result = solver.Solve(a,b,c);

            // Expected result
            string expected = $"Równanie ma dwa pierwiastki rzeczywiste";
            // Assert
            Assert.Equals(result, expected);

        }

        [Test]
        public void TestDeltaEqualsZero()
        {

            //Given
            double a = 1;
            double b = -6;
            double c = 9;

            // Arrange
            QuadraticEquationSolver solver = new QuadraticEquationSolver();

            // Result
            string result = solver.Solve(a, b, c);

            // Act
            string expected = $"Równanie ma dwa pierwiastki rzeczywiste";

            // Expected result
            Assert.Equals(result, expected);

        }

        public void TestDeltaLessThanZero()
        {

            //Given
            double a = 2;
            double b = 1;
            double c = 3;

            // Arrange
            QuadraticEquationSolver solver = new QuadraticEquationSolver();

            // Result
            string result = solver.Solve(a, b, c);

            // Act
            string expected = $"Równanie ma dwa pierwiastki rzeczywiste";

            // Expected result
            Assert.Equals(result, expected);

        }

    }
}