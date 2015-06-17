using ArtFlipSaver.Utils;
using System;
using System.Windows.Forms;

namespace ArtFlipSaver
{
    public class ScreenSaver
    {
        private BrowserVersionSelector browserVersionSelector;
        private string applicationName;
        private Func<Form> getFormToShow;
        private IApp app;

        public ScreenSaver(BrowserVersionSelector browserVersionSelector, string applicationName, IApp app, Func<Form> getFormToShow)
        {
            this.browserVersionSelector = browserVersionSelector;
            this.applicationName = applicationName;
            this.getFormToShow = getFormToShow;
            this.app = app;
        }

        public void startScreenSaver()
        {
            browserVersionSelector.MakeAppUseIE11(applicationName);
            app.Run(getFormToShow);
        }
    }
}
