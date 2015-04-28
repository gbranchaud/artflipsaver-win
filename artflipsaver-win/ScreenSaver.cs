using ArtFlipSaver.Forms;
using System;
using System.Windows.Forms;

namespace ArtFlipSaver
{
    public class ScreenSaver
    {
        private BrowserVersionSelector browserVersionSelector;
        private string applicationName;

        public ScreenSaver(BrowserVersionSelector browserVersionSelector, string applicationName)
        {
            this.browserVersionSelector = browserVersionSelector;
            this.applicationName = applicationName;
        }

        public void startScreenSaver()
        {
            browserVersionSelector.MakeAppUseIE11(applicationName);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new WebBrowserForm("http://endenizen.net/artflip/"));
        }
    }
}
