using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloworldApi;
using HelloworldApi.Controllers;
using Moq;
using HelloWorldRepository;

namespace HelloworldApi.Tests.Controllers
{
    [TestClass]
    public class HelloWorldControllerTest
    {
        [TestMethod]
        public void Greet()
        {
            // Arrange
            var mock = new Mock<IHelloWorldRepository>();
            var expectedResult = "Hello World";
            mock.Setup(hello => hello.Greet()).Returns(expectedResult);

            HelloWorldController controller = new HelloWorldController(mock.Object);

            // Act
            var actualResult = controller.Greet();

            // Assert
            Assert.IsNotNull(actualResult);          
            Assert.AreEqual(expectedResult, actualResult);           
        }
      
    }
}
