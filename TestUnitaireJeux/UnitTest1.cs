using Jeuxdevie;

namespace TestUnitaireJeux
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CountAliveNeighbors_ShouldReturnCorrectCount()
        {
            // Arrange
            string[,] grid = new string[,]
            {
            { "0", "0", "0" },
            { "0", "0", "0" },
            { "0", "0", "0" }
            };

            // Act
            int count = Services.CountAliveNeighbors(grid, 1, 1);

            // Assert
            Assert.AreEqual(8, count);
        }

        [TestMethod]
        public void CountAliveNeighbors_ShouldHandleEdges()
        {
            // Arrange
            string[,] grid = new string[,]
            {
            { "0", "0", "0" },
            { "0", "0", "0" },
            { "0", "0", "0" }
            };

            // Act
            int count = Services.CountAliveNeighbors(grid, 0, 0);

            // Assert
            Assert.AreEqual(3, count);
        }
    }
}