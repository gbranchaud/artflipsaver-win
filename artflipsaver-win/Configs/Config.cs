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

        public Config(FormType windowToShow)
        {
            WindowToShow = windowToShow;
        }
    }
}
