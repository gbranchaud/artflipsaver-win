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
            return new Config(FormType.Config);
        }
    }
}
