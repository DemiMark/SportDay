using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport
{
    public partial class Box : Form
    {
        public Box()
        {
            InitializeComponent();
        }

        private void Box_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.sport.pl/boks/0,0.html#TRNavSST#nawigacja");
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }
        private void back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}
