using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpBoy;

namespace SharpBoyTests
{
    [TestClass]
    public class DMGTests
    {
        DMG dmg;

        [TestInitialize]
        public void Setup()
        {
            dmg = new DMG();
        }

        [TestMethod]
        public void FetchGetsAnInstruction()
        {
            dmg.Fetch();
            Assert.IsNotNull(dmg.Opcode);
        }
    }
}
