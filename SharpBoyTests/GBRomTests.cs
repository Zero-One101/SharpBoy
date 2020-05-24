using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SharpBoy;

namespace SharpBoyTests
{
    [TestClass]
    public class GBRomTests
    {
        GBRom rom;

        [TestInitialize]
        public void Setup()
        {
            rom = new GBRom();
        }

        [TestMethod]
        public void LoadMethodCallsRomLoaderMethod()
        {
            var mockLoader = new Mock<IRomLoader>();
            mockLoader.Setup(m => m.ReadROM(It.IsAny<String>())).Returns(new byte[0]);
            rom.SetRomLoader(mockLoader.Object);

            rom.Load("");

            mockLoader.Verify(m => m.ReadROM(It.IsAny<String>()), Times.Once);
        }

        [TestMethod]
        public void ReadByteReturnsByteFromCorrectOffset()
        {
            var mockLoader = new Mock<IRomLoader>();
            mockLoader.Setup(m => m.ReadROM(It.IsAny<String>())).Returns(new byte[] { 2, 3, 5, 8, 13 });
            rom.SetRomLoader(mockLoader.Object);

            rom.Load("");
            byte expected = 2;
            byte actual = rom.ReadByte(0);
            Assert.AreEqual(expected, actual, "First byte");

            expected = 5;
            actual = rom.ReadByte(2);
            Assert.AreEqual(expected, actual, "Third byte");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ReadByteWithNegativeOffsetThrowsArgumentOutOfRangeException()
        {
            var mockLoader = new Mock<IRomLoader>();
            rom.SetRomLoader(mockLoader.Object);

            rom.Load("");

            rom.ReadByte(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ReadByteWithOffsetTooLargeThrowsArgumentOutOfRangeException()
        {
            var mockLoader = new Mock<IRomLoader>();
            mockLoader.Setup(m => m.ReadROM(It.IsAny<String>())).Returns(new byte[3]);
            rom.SetRomLoader(mockLoader.Object);

            rom.Load("");

            rom.ReadByte(3);
        }
    }
}
