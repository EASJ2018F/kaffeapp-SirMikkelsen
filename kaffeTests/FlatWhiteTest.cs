using System;
using kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kaffe.Tests
{
    [TestClass]
    public class FlatWhiteTest
    {
        [TestMethod]
        public void PrisTestFlatWhite()
        {
            // Arrange 
            var flatWhite = new FlatWhite();
            // Act
            int pris = flatWhite.Pris();
            // Assert
            Assert.AreEqual(45, pris);
        }

        [TestMethod]
        public void StyrkeTestFlatWhite()
        {
            // Arrange 
            var flatWhite = new FlatWhite();
            //Act
            string styrke = flatWhite.Styrke();
            // Assert
            Assert.AreEqual("Mild", styrke);
        }

        [TestMethod]

        public void MlMælk()
        {
            // Arrange 
            var flatwhite = new FlatWhite();
            //Act
            int ml = flatwhite.MlMælk();
            // Asset
            Assert.AreEqual(160, ml);
        }

    }
}
