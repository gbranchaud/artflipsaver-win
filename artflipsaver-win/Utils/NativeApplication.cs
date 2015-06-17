using System;
using System.Windows.Forms;

namespace ArtFlipSaver.Utils
{
    /// <summary>
    /// Instance class wrapping the static Application class. Allows for easier mocking.
    /// </summary>
    public class NativeApplication : IApp
    {
        public void Run(Func<Form> getFormToShow)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(getFormToShow.Invoke());
        }
    }
}
