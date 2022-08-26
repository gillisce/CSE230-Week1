
namespace CSE230_Week1
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
            this.btnChangeShape = new System.Windows.Forms.Button();
            this.btnChangeBorder = new System.Windows.Forms.Button();
            this.btnChangeOpacity = new System.Windows.Forms.Button();
            this.btnChangeFormSize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangeShape
            // 
            this.btnChangeShape.Location = new System.Drawing.Point(163, 83);
            this.btnChangeShape.Name = "btnChangeShape";
            this.btnChangeShape.Size = new System.Drawing.Size(210, 36);
            this.btnChangeShape.TabIndex = 0;
            this.btnChangeShape.Text = "Click Me";
            this.btnChangeShape.UseVisualStyleBackColor = true;
            this.btnChangeShape.Click += new System.EventHandler(this.btnChangeShape_Click);
            // 
            // btnChangeBorder
            // 
            this.btnChangeBorder.Location = new System.Drawing.Point(214, 144);
            this.btnChangeBorder.Name = "btnChangeBorder";
            this.btnChangeBorder.Size = new System.Drawing.Size(120, 40);
            this.btnChangeBorder.TabIndex = 1;
            this.btnChangeBorder.Text = "Change Border";
            this.btnChangeBorder.UseVisualStyleBackColor = true;
            this.btnChangeBorder.Click += new System.EventHandler(this.btnChangeBorder_Click);
            // 
            // btnChangeOpacity
            // 
            this.btnChangeOpacity.Location = new System.Drawing.Point(340, 205);
            this.btnChangeOpacity.Name = "btnChangeOpacity";
            this.btnChangeOpacity.Size = new System.Drawing.Size(120, 40);
            this.btnChangeOpacity.TabIndex = 2;
            this.btnChangeOpacity.Text = "Change Opacity";
            this.btnChangeOpacity.UseVisualStyleBackColor = true;
            this.btnChangeOpacity.Click += new System.EventHandler(this.btnChangeOpacity_Click);
            // 
            // btnChangeFormSize
            // 
            this.btnChangeFormSize.Location = new System.Drawing.Point(370, 144);
            this.btnChangeFormSize.Name = "btnChangeFormSize";
            this.btnChangeFormSize.Size = new System.Drawing.Size(120, 40);
            this.btnChangeFormSize.TabIndex = 3;
            this.btnChangeFormSize.Text = "Change Form Size";
            this.btnChangeFormSize.UseVisualStyleBackColor = true;
            this.btnChangeFormSize.Click += new System.EventHandler(this.btnChangeFormSize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangeFormSize);
            this.Controls.Add(this.btnChangeOpacity);
            this.Controls.Add(this.btnChangeBorder);
            this.Controls.Add(this.btnChangeShape);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangeShape;
        private System.Windows.Forms.Button btnChangeBorder;
        private System.Windows.Forms.Button btnChangeOpacity;
        private System.Windows.Forms.Button btnChangeFormSize;
    }
}

