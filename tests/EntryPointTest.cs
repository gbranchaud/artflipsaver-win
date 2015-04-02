using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArtFlipSaver;

namespace Tests
{
    [TestClass]
    public class EntryPointTest
    {
        [TestMethod]
        public void Returns1WhenUnknownArgIsPassed()
        {
            int exitCode = EntryPoint.Launch(new string[] { "invalid-arg" });
            Assert.AreEqual(1, exitCode);
        }
    }
}
