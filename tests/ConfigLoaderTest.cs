using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArtFlipSaver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class ConfigLoaderTest
    {
        [TestMethod]
        public void DefaultsToShowingConfigForm()
        {
            Config c = new ConfigLoader().FromArgs();
            Assert.AreEqual(FormType.Config, c.WindowToShow);
        }
    }
}
