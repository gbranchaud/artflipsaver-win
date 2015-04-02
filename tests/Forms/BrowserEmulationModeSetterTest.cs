using ArtFlipSaver.Forms;
using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;

namespace Tests.Forms
{
    [TestClass]
    public class BrowserEmulationModeSetterTest
    {
        [TestMethod]
        public void WritesTheRightRegistryValueSoAppUsesIE11()
        {
            new BrowserEmulationModeSetter().MakeAppUseIE11("test-app.exe");

            int appEmulationLevel = (int)Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION").GetValue("test-app.exe");
            Assert.AreEqual(11001, appEmulationLevel);

            DeleteBrowserEmulationValue("test-app.exe");
        }

        [TestMethod]
        public void ReturnsTrueWhenAValueIsWritten()
        {
            bool valueHasBeenWritten = new BrowserEmulationModeSetter().MakeAppUseIE11("new-entry.exe");
            Assert.IsTrue(valueHasBeenWritten);

            DeleteBrowserEmulationValue("new-entry.exe");
        }

        private static void DeleteBrowserEmulationValue(string appName)
        {
            var browserEmulation = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION", true);
            if (browserEmulation != null)
            {
                browserEmulation.DeleteValue(appName);
            }
        }
    }
}
