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
            if (args.Contains("/s") || args.Contains("/p"))
            {
                formToShow = FormType.ScreenSaver;
            }

            int parentWindowHandle = 0;
            if (args.Length > 1)
            {
                int.TryParse(args[1], out parentWindowHandle);
            }

            return new Config(formToShow, parentWindowHandle);
        }
    }
}
