using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adding_Controls_at_Runtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestButton_Click(object sender, EventArgs e)
        {
            Button btnGenOnFly = new Button();
            btnGenOnFly.Location = new Point(20, 20);
            btnGenOnFly.Text = "Test Button";
            this.Controls.Add(btnGenOnFly);
        }
    }
}
