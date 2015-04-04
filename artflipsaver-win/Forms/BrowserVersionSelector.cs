using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtFlipSaver.Forms
{
    public class BrowserVersionSelector
    {
        public void MakeAppUseIE11(String appName)
        {
            RegistryKey ieMain = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\MAIN\", true);
            RegistryKey browserEmulation = ieMain.CreateSubKey(@"FeatureControl\FEATURE_BROWSER_EMULATION");

            browserEmulation.SetValue(appName, 11001, RegistryValueKind.DWord);
        }
    }
}
