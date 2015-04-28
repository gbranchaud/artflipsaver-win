using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArtFlipSaver.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Configs
{
    [TestClass]
    public class ConfigLoaderTest
    {
        [TestMethod]
        public void DefaultsToShowingConfigFormAsRootWindow()
        {
            Config c = new ConfigLoader().FromArgs();

            Assert.AreEqual(FormType.Config, c.WindowToShow);
            Assert.AreEqual(0, c.ParentWindowHandle);
        }

        [TestMethod]
        public void ShowsTheConfigFormAsRootWindowWhenSlashCIsPassed()
        {
            Config c = new ConfigLoader().FromArgs(new string[] { "/c" });

            Assert.AreEqual(FormType.Config, c.WindowToShow);
            Assert.AreEqual(0, c.ParentWindowHandle);
        }

        [TestMethod]
        public void ShowsTheScreenSaverFormFullScreenWhenSlashSIsPassed()
        {
            Config c = new ConfigLoader().FromArgs(new string[] { "/s" });

            Assert.AreEqual(FormType.ScreenSaver, c.WindowToShow);
            Assert.AreEqual(0, c.ParentWindowHandle);
        }

        [TestMethod]
        public void ShowsTheScreenSaverInAPreviewWindowWhenSlashPAndHandleArePassed()
        {
            Config c = new ConfigLoader().FromArgs(new string[] { "/p", "22222" });

            Assert.AreEqual(FormType.ScreenSaver, c.WindowToShow);
            Assert.AreEqual(22222, c.ParentWindowHandle);
        }

        [TestMethod]
        public void ShowsTheConfigFormInAParentWindowWhenSlashCAndHandleArePassed()
        {
            Config c = new ConfigLoader().FromArgs(new string[] { "/c", "11111" });

            Assert.AreEqual(FormType.Config, c.WindowToShow);
            Assert.AreEqual(11111, c.ParentWindowHandle);
        }

        [TestMethod]
        public void CanParseTheParentHandleWhenColonIsUsed()
        {
            Config c = new ConfigLoader().FromArgs(new string[] { "/p:24344" });

            Assert.AreEqual(FormType.ScreenSaver, c.WindowToShow);
            Assert.AreEqual(24344, c.ParentWindowHandle);
        }

        [TestMethod]
        public void ShowsTheScreenSaverFormWhateverTheCasingOfSlashS()
        {
            Config c = new ConfigLoader().FromArgs(new string[] { "/S" });

            Assert.AreEqual(FormType.ScreenSaver, c.WindowToShow);
        }

        [TestMethod]
        public void ReturnsNullWhenTooManyArgsArePassed()
        {
            Config c = new ConfigLoader().FromArgs(new string[] { "/S", "2222", "333" });

            Assert.IsNull(c);
        }

        [TestMethod]
        public void TestModeAllowsForMoreArgs()
        {
            Config c = new ConfigLoader().FromArgs(new string[] { "/S", "2222", "-test" });

            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void AppNameIsTakenFromTheCurrentDomain()
        {
            Config c = new ConfigLoader().FromArgs();

            Assert.AreEqual(AppDomain.CurrentDomain.FriendlyName, c.ApplicationName);
        }

        [TestMethod]
        public void WhenInTestModeAppNameIsHardCoded()
        {
            Config c = new ConfigLoader().FromArgs(new string[] { "-test" });

            Assert.AreEqual("vstest.executionengine.x86.exe", c.ApplicationName);
        }
    }
}
