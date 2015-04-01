using ArtFlipSaver.Forms;

namespace ArtFlipSaver
{
    public class ScreenSaverLauncher
    {
        public static int Launch(string[] args)
        {
            if (args.Length != 0)
            {
                return 1; // todo: args parsing
            }

            new ScreenSaver().startScreenSaver();

            return 0;
        }
    }
}
