using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtFlipSaver.Forms
{
    public partial class WebBrowserForm : Form
    {
        public WebBrowserForm(string url)
        {
            InitializeComponent();

            browser.Url = new Uri(url);
        }

        private void WebBrowserForm_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            goFullScreen();
        }

        private void browser_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            this.Close();
        }

        private void goFullScreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
