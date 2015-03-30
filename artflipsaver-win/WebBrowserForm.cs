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
    public partial class WebBrowserForm : Form
    {
        public WebBrowserForm(string url)
        {
            InitializeComponent();

            browser.Url = new Uri(url);
        }

    }
}
