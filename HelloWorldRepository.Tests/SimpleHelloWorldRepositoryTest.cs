using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldRepository.Tests
{
    /// <summary>
    /// Tests the Greet method of SimpleHelloWorldReposistory class.
    /// </summary>
    [TestClass]
    public class SimpleHelloWorldRepositoryTest
    {
        [TestMethod]
        public void Greet()
        {
            // Arrange
            var simpleHelloWorldRepository = new SimpleHelloWorldReposistory();
            var expectedResult = "Hello World";

            // Act
            var actualResult = simpleHelloWorldRepository.Greet();

            // Assert
            Assert.IsNotNull(actualResult);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
