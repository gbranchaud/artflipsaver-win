using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArtFlipSaver.Forms
{
    public class ScreenSaver
    {
        public ScreenSaver()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }

        public void startScreenSaver()
        {
            Application.Run(new WebBrowserForm("http://endenizen.net/artflip/"));
        }
    }
}
