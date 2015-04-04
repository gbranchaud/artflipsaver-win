using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArtFlipSaver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class ArgumentsParserTest
    {
        [TestMethod]
        [Ignore]
        public void KnowsThatNoArgsMeansToShowTheConfigDialog()
        {
            ArgumentsParser parser = new ArgumentsParser();
            parser.Parse(new string[] { "d", "d" });
            // TODO: complete this
        }
    }
}
