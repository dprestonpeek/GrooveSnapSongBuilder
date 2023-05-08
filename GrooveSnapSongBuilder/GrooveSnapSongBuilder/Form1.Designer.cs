
namespace GrooveSnapSongBuilder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BrowseTabButton = new System.Windows.Forms.Button();
            this.TabFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputPath = new System.Windows.Forms.TextBox();
            this.BrowseOutputButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.OpenDirCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // BrowseTabButton
            // 
            this.BrowseTabButton.Location = new System.Drawing.Point(12, 66);
            this.BrowseTabButton.Name = "BrowseTabButton";
            this.BrowseTabButton.Size = new System.Drawing.Size(277, 23);
            this.BrowseTabButton.TabIndex = 0;
            this.BrowseTabButton.Text = "Choose Tab File...";
            this.BrowseTabButton.UseVisualStyleBackColor = true;
            this.BrowseTabButton.Click += new System.EventHandler(this.BrowseTabButton_Click);
            // 
            // TabFilePath
            // 
            this.TabFilePath.Location = new System.Drawing.Point(12, 37);
            this.TabFilePath.Name = "TabFilePath";
            this.TabFilePath.Size = new System.Drawing.Size(277, 23);
            this.TabFilePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Upload Guitar Pro file to convert to midi:";
            // 
            // OutputPath
            // 
            this.OutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OutputPath.Location = new System.Drawing.Point(10, 128);
            this.OutputPath.Name = "OutputPath";
            this.OutputPath.Size = new System.Drawing.Size(279, 23);
            this.OutputPath.TabIndex = 10;
            // 
            // BrowseOutputButton
            // 
            this.BrowseOutputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BrowseOutputButton.Location = new System.Drawing.Point(12, 157);
            this.BrowseOutputButton.Name = "BrowseOutputButton";
            this.BrowseOutputButton.Size = new System.Drawing.Size(277, 23);
            this.BrowseOutputButton.TabIndex = 9;
            this.BrowseOutputButton.Text = "Choose Output File...";
            this.BrowseOutputButton.UseVisualStyleBackColor = true;
            this.BrowseOutputButton.Click += new System.EventHandler(this.BrowseOutputButton_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ConvertButton.Location = new System.Drawing.Point(12, 219);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(277, 23);
            this.ConvertButton.TabIndex = 11;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // OpenDirCheck
            // 
            this.OpenDirCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenDirCheck.AutoSize = true;
            this.OpenDirCheck.Checked = true;
            this.OpenDirCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OpenDirCheck.Location = new System.Drawing.Point(11, 286);
            this.OpenDirCheck.Name = "OpenDirCheck";
            this.OpenDirCheck.Size = new System.Drawing.Size(182, 19);
            this.OpenDirCheck.TabIndex = 12;
            this.OpenDirCheck.Text = "Open directory when finished";
            this.OpenDirCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(82, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "(.gp3, .gp4, .gp5, .gpx, .gp)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "midi";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(121, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "(.midi, .mid)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResetButton.Location = new System.Drawing.Point(199, 282);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(90, 23);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 248);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(277, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 16;
            this.progressBar1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 314);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenDirCheck);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.OutputPath);
            this.Controls.Add(this.BrowseOutputButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TabFilePath);
            this.Controls.Add(this.BrowseTabButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GrooveSnap GP->Midi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseTabButton;
        private System.Windows.Forms.TextBox TabFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutputPath;
        private System.Windows.Forms.Button BrowseOutputButton;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.CheckBox OpenDirCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

