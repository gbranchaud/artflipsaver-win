using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
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
            Application.AddMessageFilter(new DetectSignificantMouseMove());
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

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        private class DetectSignificantMouseMove : IMessageFilter
        {
            private const int MOUSE_MOVE = 0x0200;
            private const int MOVEMENT_THRESHOLD = 10;
            private Point previousPosition = Point.Empty;

            public bool PreFilterMessage(ref Message m)
            {
                if (m.Msg != MOUSE_MOVE)
                {
                    return false;
                }
                Point currentMousePos = Cursor.Position;
                if (previousPosition == Point.Empty)
                {
                    previousPosition = currentMousePos;
                }

                if (MouseMoveWasSignificant(previousPosition, currentMousePos))
                {
                    Console.WriteLine("Mouse move was significant. TODO: Fire Event to indicate time to close.");
                }
                return false;
            }

            private bool MouseMoveWasSignificant(Point previousPosition, Point currentMousePos)
            {
                return Math.Abs(previousPosition.X - currentMousePos.X) > MOVEMENT_THRESHOLD ||
                    Math.Abs(previousPosition.Y - currentMousePos.Y) > MOVEMENT_THRESHOLD;
            }
        }
    }
}
