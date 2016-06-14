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
    public partial class Add : Form
    {
        Last an = new Last();
        public Add()
        {
            InitializeComponent();
        }

        private void another_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            save.site_name = tb_siteName.Text;
            save.site_URL = tb_siteURL.Text;
            save.WriteParam();
            this.Close();
            an.Show();
        }

        private void tb_siteName_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
