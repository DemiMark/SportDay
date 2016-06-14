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
    public partial class menu : Form
    {
        
        Football fb = new Football();
        Tennis tn = new Tennis();
        basketball bb = new basketball();
        Golf gf = new Golf();
        Box box = new Box();
        Add an = new Add();
        Last an2 = new Last();
        

        public menu()
        {
            InitializeComponent();
        }

        private void football_Click(object sender, EventArgs e)
        {
            fb.Show();
        }

        private void tennis_Click(object sender, EventArgs e)
        {
            tn.Show();
        }

        private void basketball_Click(object sender, EventArgs e)
        {
            bb.Show();
        }

        private void golf_Click(object sender, EventArgs e)
        {
            gf.Show();
        }

        private void boxing_Click(object sender, EventArgs e)
        {
            box.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            //football button
            System.Drawing.Drawing2D.GraphicsPath myPath =
            new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, football.Width, football.Height);

            Region myRegion = new Region(myPath);
            football.Region = myRegion;

            //basketball button
            System.Drawing.Drawing2D.GraphicsPath myPath1 =
            new System.Drawing.Drawing2D.GraphicsPath();
            myPath1.AddEllipse(0, 0, basketball.Width, basketball.Height);

            Region myRegion1 = new Region(myPath1);
            basketball.Region = myRegion1;

            //box button
            System.Drawing.Drawing2D.GraphicsPath myPath2 =
            new System.Drawing.Drawing2D.GraphicsPath();
            myPath2.AddEllipse(0, 0, boxing.Width, boxing.Height);

            Region myRegion2 = new Region(myPath2);
            boxing.Region = myRegion2;

            //golf button
            System.Drawing.Drawing2D.GraphicsPath myPath3 =
            new System.Drawing.Drawing2D.GraphicsPath();
            myPath3.AddEllipse(0, 0, golf.Width, golf.Height);

            Region myRegion3 = new Region(myPath3);
            golf.Region = myRegion3;

            //tennis button
            System.Drawing.Drawing2D.GraphicsPath myPath4 =
            new System.Drawing.Drawing2D.GraphicsPath();
            myPath4.AddEllipse(0, 0, tennis.Width, tennis.Height);

            Region myRegion4 = new Region(myPath4);
            tennis.Region = myRegion4;


            save.ReadParam();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void footballToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fb.Show();
        }

        private void boxingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            box.Show();
        }

        private void tennisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tennis.Show();
        }

        private void basketballToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bb.Show();
        }

        private void golfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            golf.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void another_Click(object sender, EventArgs e)
        {
            an.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            an2.Show();
        }
    }
}
