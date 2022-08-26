using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSE230_Week1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.CornflowerBlue;
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void btnChangeShape_Click(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath mypath = new
            System.Drawing.Drawing2D.GraphicsPath();
            mypath.AddEllipse(0, 0, this.Width, this.Height);
            Region myRegion = new Region(mypath);
            this.Region = myRegion;
        }

        private void btnChangeBorder_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void btnChangeOpacity_Click(object sender, EventArgs e)
        {
            this.Opacity = .4;
        }

        private void btnChangeFormSize_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }
    }
}
