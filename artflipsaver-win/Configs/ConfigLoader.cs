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
            if (ArgumentsAreInvalid(args))
            {
                return null;
            }

            FormType formToShow = GetFormToShow(args);
            int parentWindowHandle = GetParentWindowHandle(args);
            string applicationName = GetApplicationName(args);
            return new Config(formToShow, parentWindowHandle, applicationName);
        }

        private bool ArgumentsAreInvalid(string[] args)
        {
            return args.Length > 3 || (args.Length == 3 && !args.Contains("-test", StringComparer.OrdinalIgnoreCase));
        }

        private FormType GetFormToShow(string[] args)
        {
            string modeSwitch = args.Length == 0 ? "" : args[0];
            if (modeSwitch.StartsWith("/s", StringComparison.OrdinalIgnoreCase) || modeSwitch.StartsWith("/p", StringComparison.OrdinalIgnoreCase))
            {
                return FormType.ScreenSaver;
            }
            return FormType.Config;
        }

        private int GetParentWindowHandle(string[] args)
        {
            int parentWindowHandle = 0;
            string modeSwitch = args.Length == 0 ? "" : args[0];
            if (modeSwitch.Contains(":"))
            {
                string rawParentWindowHandle = modeSwitch.Split(new char[] { ':' })[1];
                int.TryParse(rawParentWindowHandle, out parentWindowHandle);
            }
            else if (args.Length > 1)
            {
                int.TryParse(args[1], out parentWindowHandle);
            }
            return parentWindowHandle;
        }

        private string GetApplicationName(string[] args)
        {
            if (args.Contains("-test", StringComparer.OrdinalIgnoreCase))
            {
                return "vstest.executionengine.x86.exe";
            }
            return AppDomain.CurrentDomain.FriendlyName;
        }
    }
}
