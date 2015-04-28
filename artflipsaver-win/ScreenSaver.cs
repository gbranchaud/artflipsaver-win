using ArtFlipSaver.Forms;
using System;
using System.Windows.Forms;

namespace ArtFlipSaver
{
    public class ScreenSaver
    {
        private BrowserVersionSelector browserVersionSelector;
        private string applicationName;
        private Func<Form> getFormToShow;

        public ScreenSaver(BrowserVersionSelector browserVersionSelector, string applicationName, Func<Form> getFormToShow)
        {
            this.browserVersionSelector = browserVersionSelector;
            this.applicationName = applicationName;
            this.getFormToShow = getFormToShow;
        }

        public void startScreenSaver()
        {
            browserVersionSelector.MakeAppUseIE11(applicationName);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(getFormToShow.Invoke());
        }
    }
}
