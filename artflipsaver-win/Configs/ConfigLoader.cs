using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtFlipSaver.Configs
{
    public class ConfigLoader
    {
        public Config FromArgs(params string[] args)
        {
            FormType formToShow = FormType.Config;
            int parentWindowHandle = 0;

            if (args.Length == 0)
            {
                return new Config(formToShow, parentWindowHandle);
            }

            string modeSwitch = args[0];
            if (modeSwitch.StartsWith("/s", StringComparison.OrdinalIgnoreCase) || modeSwitch.StartsWith("/p", StringComparison.OrdinalIgnoreCase))
            {
                formToShow = FormType.ScreenSaver;
            }

            if (modeSwitch.Contains(":"))
            {
                string rawParentWindowHandle = modeSwitch.Split(new char[] { ':' })[1];
                int.TryParse(rawParentWindowHandle, out parentWindowHandle);
            }
            else if (args.Length > 1)
            {
                int.TryParse(args[1], out parentWindowHandle);
            }

            return new Config(formToShow, parentWindowHandle);
        }
    }
}
