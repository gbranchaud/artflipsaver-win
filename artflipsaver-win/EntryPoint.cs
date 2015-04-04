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
            if (args.Length != 0)
            {
                return 1; // todo: args parsing
            }

            new ScreenSaver(new BrowserVersionSelector()).startScreenSaver();

            return 0;
        }
    }
}
