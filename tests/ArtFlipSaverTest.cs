using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using artflipsaver_win;

namespace tests
{
    [TestClass]
    public class ArtFlipSaverTest
    {
        [TestMethod]
        public void Returns1WhenUnknownArgIsPassed()
        {
            int exitCode = ArtFlipSaver.Launch(new string[] { "invalid-arg" });
            Assert.AreEqual(1, exitCode);
        }
    }
}
