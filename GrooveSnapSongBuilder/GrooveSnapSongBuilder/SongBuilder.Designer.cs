
namespace GrooveSnapSongBuilder
{
    partial class SongBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongBuilder));
            this.label1 = new System.Windows.Forms.Label();
            this.FilesList = new System.Windows.Forms.ListBox();
            this.AddFiles = new System.Windows.Forms.Button();
            this.DeleteFiles = new System.Windows.Forms.Button();
            this.ClearFiles = new System.Windows.Forms.Button();
            this.GP2MidiButton = new System.Windows.Forms.Button();
            this.UnpackExistingButton = new System.Windows.Forms.Button();
            this.BuildButton = new System.Windows.Forms.Button();
            this.CheckMaterialsButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OpenDir = new System.Windows.Forms.CheckBox();
            this.openZipDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.AddDrumMapButton = new System.Windows.Forms.Button();
            this.AddInfoFileButton = new System.Windows.Forms.Button();
            this.saveDrumMapDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveInfoDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Files:";
            // 
            // FilesList
            // 
            this.FilesList.FormattingEnabled = true;
            this.FilesList.ItemHeight = 15;
            this.FilesList.Location = new System.Drawing.Point(12, 27);
            this.FilesList.Name = "FilesList";
            this.FilesList.Size = new System.Drawing.Size(277, 109);
            this.FilesList.TabIndex = 1;
            // 
            // AddFiles
            // 
            this.AddFiles.Location = new System.Drawing.Point(214, 142);
            this.AddFiles.Name = "AddFiles";
            this.AddFiles.Size = new System.Drawing.Size(75, 23);
            this.AddFiles.TabIndex = 2;
            this.AddFiles.Text = "Add File(s)";
            this.AddFiles.UseVisualStyleBackColor = true;
            this.AddFiles.Click += new System.EventHandler(this.AddFiles_Click);
            // 
            // DeleteFiles
            // 
            this.DeleteFiles.Location = new System.Drawing.Point(12, 142);
            this.DeleteFiles.Name = "DeleteFiles";
            this.DeleteFiles.Size = new System.Drawing.Size(62, 23);
            this.DeleteFiles.TabIndex = 3;
            this.DeleteFiles.Text = "Delete";
            this.DeleteFiles.UseVisualStyleBackColor = true;
            this.DeleteFiles.Click += new System.EventHandler(this.DeleteFiles_Click);
            // 
            // ClearFiles
            // 
            this.ClearFiles.Location = new System.Drawing.Point(80, 142);
            this.ClearFiles.Name = "ClearFiles";
            this.ClearFiles.Size = new System.Drawing.Size(48, 23);
            this.ClearFiles.TabIndex = 4;
            this.ClearFiles.Text = "Clear";
            this.ClearFiles.UseVisualStyleBackColor = true;
            this.ClearFiles.Click += new System.EventHandler(this.ClearFiles_Click);
            // 
            // GP2MidiButton
            // 
            this.GP2MidiButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GP2MidiButton.Location = new System.Drawing.Point(12, 336);
            this.GP2MidiButton.Name = "GP2MidiButton";
            this.GP2MidiButton.Size = new System.Drawing.Size(277, 23);
            this.GP2MidiButton.TabIndex = 5;
            this.GP2MidiButton.Text = "GP->Midi Conversion Tool";
            this.GP2MidiButton.UseVisualStyleBackColor = true;
            this.GP2MidiButton.Click += new System.EventHandler(this.GP2MidiButton_Click);
            // 
            // UnpackExistingButton
            // 
            this.UnpackExistingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnpackExistingButton.Location = new System.Drawing.Point(12, 307);
            this.UnpackExistingButton.Name = "UnpackExistingButton";
            this.UnpackExistingButton.Size = new System.Drawing.Size(277, 23);
            this.UnpackExistingButton.TabIndex = 6;
            this.UnpackExistingButton.Text = "Unpack Existing .gs File";
            this.UnpackExistingButton.UseVisualStyleBackColor = true;
            this.UnpackExistingButton.Click += new System.EventHandler(this.UnpackExistingButton_Click);
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(12, 240);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(277, 23);
            this.BuildButton.TabIndex = 7;
            this.BuildButton.Text = "Build .gs File";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // CheckMaterialsButton
            // 
            this.CheckMaterialsButton.Location = new System.Drawing.Point(12, 211);
            this.CheckMaterialsButton.Name = "CheckMaterialsButton";
            this.CheckMaterialsButton.Size = new System.Drawing.Size(277, 23);
            this.CheckMaterialsButton.TabIndex = 8;
            this.CheckMaterialsButton.Text = "Check Materials";
            this.CheckMaterialsButton.UseVisualStyleBackColor = true;
            this.CheckMaterialsButton.Click += new System.EventHandler(this.CheckMaterialsButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "gs";
            // 
            // OpenDir
            // 
            this.OpenDir.AutoSize = true;
            this.OpenDir.Checked = true;
            this.OpenDir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OpenDir.Location = new System.Drawing.Point(13, 270);
            this.OpenDir.Name = "OpenDir";
            this.OpenDir.Size = new System.Drawing.Size(182, 19);
            this.OpenDir.TabIndex = 9;
            this.OpenDir.Text = "Open directory when finished";
            this.OpenDir.UseVisualStyleBackColor = true;
            // 
            // openZipDialog2
            // 
            this.openZipDialog2.FileName = "openFileDialog2";
            // 
            // AddDrumMapButton
            // 
            this.AddDrumMapButton.Location = new System.Drawing.Point(12, 182);
            this.AddDrumMapButton.Name = "AddDrumMapButton";
            this.AddDrumMapButton.Size = new System.Drawing.Size(131, 23);
            this.AddDrumMapButton.TabIndex = 10;
            this.AddDrumMapButton.Text = "Add Drum Map";
            this.AddDrumMapButton.UseVisualStyleBackColor = true;
            this.AddDrumMapButton.Click += new System.EventHandler(this.AddDrumMapButton_Click);
            // 
            // AddInfoFileButton
            // 
            this.AddInfoFileButton.Location = new System.Drawing.Point(158, 182);
            this.AddInfoFileButton.Name = "AddInfoFileButton";
            this.AddInfoFileButton.Size = new System.Drawing.Size(131, 23);
            this.AddInfoFileButton.TabIndex = 11;
            this.AddInfoFileButton.Text = "Add Info File";
            this.AddInfoFileButton.UseVisualStyleBackColor = true;
            this.AddInfoFileButton.Click += new System.EventHandler(this.AddInfoFileButton_Click);
            // 
            // saveDrumMapDialog
            // 
            this.saveDrumMapDialog.DefaultExt = "txt";
            this.saveDrumMapDialog.FileName = "drummap.txt";
            // 
            // saveInfoDialog
            // 
            this.saveInfoDialog.DefaultExt = "txt";
            this.saveInfoDialog.FileName = "info.txt";
            // 
            // SongBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 371);
            this.Controls.Add(this.AddInfoFileButton);
            this.Controls.Add(this.AddDrumMapButton);
            this.Controls.Add(this.OpenDir);
            this.Controls.Add(this.CheckMaterialsButton);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.UnpackExistingButton);
            this.Controls.Add(this.GP2MidiButton);
            this.Controls.Add(this.ClearFiles);
            this.Controls.Add(this.DeleteFiles);
            this.Controls.Add(this.AddFiles);
            this.Controls.Add(this.FilesList);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SongBuilder";
            this.Text = "SongBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox FilesList;
        private System.Windows.Forms.Button AddFiles;
        private System.Windows.Forms.Button DeleteFiles;
        private System.Windows.Forms.Button ClearFiles;
        private System.Windows.Forms.Button GP2MidiButton;
        private System.Windows.Forms.Button UnpackExistingButton;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.Button CheckMaterialsButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox OpenDir;
        private System.Windows.Forms.OpenFileDialog openZipDialog2;
        private System.Windows.Forms.Button AddDrumMapButton;
        private System.Windows.Forms.Button AddInfoFileButton;
        private System.Windows.Forms.SaveFileDialog saveDrumMapDialog;
        private System.Windows.Forms.SaveFileDialog saveInfoDialog;
    }
}