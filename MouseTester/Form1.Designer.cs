namespace MouseTester
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.testArea = new System.Windows.Forms.Panel();
            this.debugOutput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.testArea);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Area";
            // 
            // testArea
            // 
            this.testArea.AutoScroll = true;
            this.testArea.BackColor = System.Drawing.Color.Gray;
            this.testArea.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.testArea.Location = new System.Drawing.Point(7, 20);
            this.testArea.Name = "testArea";
            this.testArea.Size = new System.Drawing.Size(346, 175);
            this.testArea.TabIndex = 0;
            this.testArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.testArea_MouseDown);
            this.testArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.testArea_MouseUp);
            // 
            // debugOutput
            // 
            this.debugOutput.Enabled = false;
            this.debugOutput.Location = new System.Drawing.Point(20, 221);
            this.debugOutput.Multiline = true;
            this.debugOutput.Name = "debugOutput";
            this.debugOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debugOutput.Size = new System.Drawing.Size(346, 145);
            this.debugOutput.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 378);
            this.Controls.Add(this.debugOutput);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MouseTester";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel testArea;
        private System.Windows.Forms.TextBox debugOutput;
    }
}

