using ArtFlipSaver.Forms;
using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;

namespace Tests.Forms
{
    [TestClass]
    public class BrowserVersionSelector
    {
        [TestMethod]
        public void AddsTheValueWhenItIsNotPresent()
        {
            DeleteBrowserEmulationValue("new-value.exe");

            new BrowserVersionSelector().MakeAppUseIE11("new-value.exe");

            int valueForTheApp = (int)Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION").GetValue("new-value.exe");
            Assert.AreEqual(11001, valueForTheApp);

            DeleteBrowserEmulationValue("new-value.exe");
        }

        [TestMethod]
        public void UpdatesAnExistingRegistryValue()
        {
            Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION").SetValue("existing-value.exe", "BAD_VALUE", RegistryValueKind.String);

            new BrowserVersionSelector().MakeAppUseIE11("existing-value.exe");

            int valueForTheApp = (int)Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION").GetValue("existing-value.exe");
            Assert.AreEqual(11001, valueForTheApp);

            DeleteBrowserEmulationValue("existing-value.exe");
        }

        private static void DeleteBrowserEmulationValue(string appName)
        {
            var browserEmulation = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION", true);
            if (browserEmulation != null)
            {
                browserEmulation.DeleteValue(appName, false);
            }
        }
    }
}
