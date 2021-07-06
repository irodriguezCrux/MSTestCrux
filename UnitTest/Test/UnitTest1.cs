using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumValues()
        {
            //AAA

            //Arrange
            ApplicationCore.Services.Sum suma = new ApplicationCore.Services.Sum();

            //Act
            var result = suma.SumValues(5, 2);
            //

            //Assert
            Assert.AreEqual(5, result);

        }
    }
} 
