namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculateSqrt_WithPositiveNumber()
        {
            // Arrange
            SqrtCalculator calculator = new SqrtCalculator();
            double input = 25; // przyklad liczny dodatniej
            // Act
            double result = calculator.CalculateSqrt(input);

            // Assert
            Assert.AreEqual(5, result); // Pierwiastek kwadratowy z 25 to 5
        }

        [TestMethod]
        public void TestCalculateSqrt_WithZero()
        {
            // Arrange
            SqrtCalculator calculator = new SqrtCalculator();
            double input = 0;

            // Act
            double result = calculator.CalculateSqrt(input);

            // Assert
            Assert.AreEqual(0, result); // Pierwiastek kwadratowy z 0 to 0
        }

        [TestMethod]
        public void TestCalculateSqrt_WithNegativeNumber()
        {
            // Arrange
            SqrtCalculator calculator = new SqrtCalculator();
            double input = -10; // przyklad liczby ujemnej

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => calculator.CalculateSqrt(input));
        }
    }
}