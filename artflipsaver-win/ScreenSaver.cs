using ArtFlipSaver.Forms;
using System;
using System.Windows.Forms;

namespace ArtFlipSaver
{
    public class ScreenSaver
    {
        private BrowserEmulationModeSetter browserEmulationModeSetter;

        public ScreenSaver(BrowserEmulationModeSetter browserEmulationModeSetter)
        {
            this.browserEmulationModeSetter = browserEmulationModeSetter;
        }

        public void startScreenSaver()
        {
            browserEmulationModeSetter.MakeAppUseIE11(AppDomain.CurrentDomain.FriendlyName);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new WebBrowserForm("http://endenizen.net/artflip/"));
        }
    }
}
