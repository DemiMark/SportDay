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
    public partial class Football : Form
    {
        
        public Football()
        {
            InitializeComponent();
        }

        private void Football_Load(object sender, EventArgs e)
        {
            browser.Navigate("http://www.sport.pl/pilka/0,64946.html#TRNavSST");
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
          
            
        }
        private void Form1_OnClose()
        {
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            browser.GoBack();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            browser.GoForward();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            browser.Refresh();
        }
    }
}
