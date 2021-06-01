using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture29_Lesson1
{
    public partial class frmWebBrowser : Form
    {
        public frmWebBrowser()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtAddress.Text);
        }

        private void btnGoForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtAddress.Text = webBrowser1.Url.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}
