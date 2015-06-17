using ArtFlipSaver;
using ArtFlipSaver.Utils;
using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace Tests
{
    [TestClass]
    public class ScreenSaverTest
    {
        private BrowserVersionSelector browserVersionSelector;
        private IApp nativeApplication;
        private Func<Form> formGenerator;
        private ScreenSaver screenSaver;

        [TestInitialize]
        public void theScreenSaver()
        {
            browserVersionSelector = A.Dummy<BrowserVersionSelector>();
            nativeApplication = A.Fake<IApp>();
            formGenerator = A.Dummy<Func<Form>>();

            screenSaver = new ScreenSaver(browserVersionSelector, A.Dummy<String>(), nativeApplication, formGenerator);
        }

        [TestMethod]
        public void mustPassTheFormGeneratorToTheApp()
        {
            screenSaver.startScreenSaver();

            A.CallTo(() => nativeApplication.Run(formGenerator)).MustHaveHappened();
        }
    }
}
