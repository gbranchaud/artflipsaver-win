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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ScreenSaverForm());
            return 0;
        }
    }
}
