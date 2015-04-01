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
            return ScreenSaverLauncher.Launch(args);
        }
    }
}
