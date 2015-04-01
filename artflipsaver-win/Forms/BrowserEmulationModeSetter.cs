using ArtFlipSaver.Registry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtFlipSaver.Forms
{
    public class BrowserEmulationModeSetter
    {
        private IRegistryWriter registryWriter;

        public BrowserEmulationModeSetter(IRegistryWriter registryWriter)
        {
            this.registryWriter = registryWriter;
        }

        public void setToIE11()
        {
            registryWriter.WriteDword(@"SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION", "artflipsaver-win.scr", 11001);
        }
    }
}
