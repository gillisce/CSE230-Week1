using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowLayoutPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            flowLayoutPanel1.SetFlowBreak(button1, true);
            flowLayoutPanel1.SetFlowBreak(button3, true);
            flowLayoutPanel1.SetFlowBreak(button5, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowFlowBreak(sender);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ShowFlowBreak(sender);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ShowFlowBreak(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowFlowBreak(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowFlowBreak(sender);
        }



        private void ShowFlowBreak(object sender)
        {
            Button btnClicked = sender as Button;
            if (flowLayoutPanel1.GetFlowBreak(btnClicked))
            {
                MessageBox.Show("Flowbreak is set");
            }
            else
            {
                MessageBox.Show("Flowbreak is NOT set");
            }
        }

    }
}
