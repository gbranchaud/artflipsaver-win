using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArtFlipSaver;

namespace Tests
{
    [TestClass]
    public class EntryPointTest
    {
        [TestMethod]
        public void Returns1WhenTooMuchArgsArePassed()
        {
            int exitCode = EntryPoint.Launch(new string[] { "invalid", "number", "of", "args" });
            Assert.AreEqual(1, exitCode);
        }
    }
}
