using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace artflipsaver_win
{
    public class ArtFlipSaver
    {
        public static int Launch(string[] args)
        {
            if (args.Length != 0)
            {
                return 1;
            }

            // todo: args parsing

            new ArtFlipSaver().startScreenSaver();

            return 0;
        }

        private ArtFlipSaver()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }

        private void startScreenSaver()
        {
            Application.Run(new WebBrowserForm("http://endenizen.net/artflip/"));
        }
    }
}
