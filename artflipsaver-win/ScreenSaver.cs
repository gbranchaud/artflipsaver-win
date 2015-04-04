using ArtFlipSaver.Forms;
using System;
using System.Windows.Forms;

namespace ArtFlipSaver
{
    public class ScreenSaver
    {
        private BrowserVersionSelector browserVersionSelector;

        public ScreenSaver(BrowserVersionSelector browserVersionSelector)
        {
            this.browserVersionSelector = browserVersionSelector;
        }

        public void startScreenSaver()
        {
            browserVersionSelector.MakeAppUseIE11(AppDomain.CurrentDomain.FriendlyName);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new WebBrowserForm("http://endenizen.net/artflip/"));
        }
    }
}
