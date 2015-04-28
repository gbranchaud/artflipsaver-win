using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtFlipSaver.Configs
{
    public enum FormType
    {
        Config,
        ScreenSaver
    }

    public class Config
    {
        public FormType WindowToShow { get; private set; }
        public int ParentWindowHandle { get; set; }
        public string ApplicationName { get; set; }

        public Config(FormType windowToShow, int parentWindowHandle, string applicationName)
        {
            WindowToShow = windowToShow;
            ParentWindowHandle = parentWindowHandle;
            ApplicationName = applicationName;
        }
    }
}
