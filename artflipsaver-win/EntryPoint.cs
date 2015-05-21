using ArtFlipSaver.Configs;
using ArtFlipSaver.Forms;
using ArtFlipSaver.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtFlipSaver
{
    public class EntryPoint
    {
        [STAThread]
        static int Main(string[] args)
        {
            return Launch(args);
        }

        public static int Launch(string[] args)
        {
            var config = new ConfigLoader().FromArgs(args);
            if (config == null)
            {
                return 1;
            }

            Func<Form> getFormToShow = config.WindowToShow == FormType.ScreenSaver ? () => new WebBrowserForm("http://endenizen.net/artflip/") : (Func<Form>)(() => new SettingsForm());

            new ScreenSaver(new BrowserVersionSelector(), config.ApplicationName, getFormToShow).startScreenSaver();

            return 0;
        }
    }
}
