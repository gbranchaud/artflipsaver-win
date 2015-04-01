using ArtFlipSaver.Forms;
using ArtFlipSaver.Registry;
using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Forms
{
    [TestClass]
    public class BrowserEmulationModeSetterTest
    {
        [TestMethod]
        public void callsTheRegistryWriterWithIE11DataValue()
        {
            var registryWriter = A.Fake<IRegistryWriter>();

            new BrowserEmulationModeSetter(registryWriter).setToIE11();

            A.CallTo(() => registryWriter.WriteDword(A<string>._, A<string>._, 11001)).MustHaveHappened();
        }
    }
}
