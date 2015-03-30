using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artflipsaver_win
{
    public partial class ScreenSaverForm : Form
    {
        public ScreenSaverForm()
        {
            InitializeComponent();

            browser.Url = new Uri("http://endenizen.net/artflip/");
        }

    }
}
