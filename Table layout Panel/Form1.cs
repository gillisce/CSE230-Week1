using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Table_layout_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNewButton_Click(object sender, EventArgs e)
        {
            Button abutton = new Button();
            abutton.Text = "New Button 6";
            abutton.Width = 150;
            //To Specify which Cell
            tableLayoutPanel1.Controls.Add(abutton, 2, 1);
        }
    }
}
