using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artflipsaver_win
{
    static class EntryPoint
    {
        [STAThread]
        static void Main(string[] args)
        {
            ArtFlipSaver.Launch(args);
        }
    }
}
