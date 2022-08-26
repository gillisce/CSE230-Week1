
namespace SplitControlContainer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.parentContainer = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.listboxContainer = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.parentContainer)).BeginInit();
            this.parentContainer.Panel1.SuspendLayout();
            this.parentContainer.Panel2.SuspendLayout();
            this.parentContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listboxContainer)).BeginInit();
            this.listboxContainer.Panel1.SuspendLayout();
            this.listboxContainer.Panel2.SuspendLayout();
            this.listboxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // parentContainer
            // 
            this.parentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentContainer.Location = new System.Drawing.Point(0, 0);
            this.parentContainer.Name = "parentContainer";
            this.parentContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // parentContainer.Panel1
            // 
            this.parentContainer.Panel1.Controls.Add(this.button1);
            // 
            // parentContainer.Panel2
            // 
            this.parentContainer.Panel2.Controls.Add(this.listboxContainer);
            this.parentContainer.Size = new System.Drawing.Size(938, 589);
            this.parentContainer.SplitterDistance = 99;
            this.parentContainer.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listboxContainer
            // 
            this.listboxContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxContainer.Location = new System.Drawing.Point(0, 0);
            this.listboxContainer.Name = "listboxContainer";
            // 
            // listboxContainer.Panel1
            // 
            this.listboxContainer.Panel1.Controls.Add(this.listBox1);
            // 
            // listboxContainer.Panel2
            // 
            this.listboxContainer.Panel2.Controls.Add(this.listBox2);
            this.listboxContainer.Size = new System.Drawing.Size(938, 486);
            this.listboxContainer.SplitterDistance = 312;
            this.listboxContainer.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 446);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(65, 73);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(530, 368);
            this.listBox2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 589);
            this.Controls.Add(this.parentContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.parentContainer.Panel1.ResumeLayout(false);
            this.parentContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parentContainer)).EndInit();
            this.parentContainer.ResumeLayout(false);
            this.listboxContainer.Panel1.ResumeLayout(false);
            this.listboxContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listboxContainer)).EndInit();
            this.listboxContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer parentContainer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer listboxContainer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

