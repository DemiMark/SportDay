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
    public partial class Last : Form
    {
        MySite ns = new MySite();
        public Last()
        {
            InitializeComponent();
        }

        private void another_site_Load(object sender, EventArgs e)
        {
            lbl_site.Text = save.site_name;
            save.ReadParam();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            ns.Show();
            this.Hide();
        }
    }
}
