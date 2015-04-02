using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtFlipSaver.Forms
{
    public class BrowserEmulationModeSetter
    {
        public bool MakeAppUseIE11(String appName)
        {
            RegistryKey ieMain = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\MAIN\", true);
            RegistryKey browserEmulation = ieMain.CreateSubKey(@"FeatureControl\FEATURE_BROWSER_EMULATION");

            var appValue = browserEmulation.GetValue(appName);
            if (appValue != null)
            {
                return false;
            }

            browserEmulation.SetValue(appName, 11001, RegistryValueKind.DWord);
            return true;
        }
    }
}
