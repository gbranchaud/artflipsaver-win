using ArtFlipSaver.Configs;
using ArtFlipSaver.Forms;
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

            new ScreenSaver(new BrowserVersionSelector()).startScreenSaver();

            return 0;
        }
    }
}
