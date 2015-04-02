using ArtFlipSaver.Forms;
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
            string appName = "artflipsaver-win.vshost.exe"; // todo: get real name of app
            browserEmulationModeSetter.MakeAppUseIE11(appName);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new WebBrowserForm("http://endenizen.net/artflip/"));
        }
    }
}
