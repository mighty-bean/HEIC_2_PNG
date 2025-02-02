namespace HEIC2PNG
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Test Item");
            this.ChooseFolder = new System.Windows.Forms.Button();
            this.FolderPath = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.FileList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ChooseFolder
            // 
            this.ChooseFolder.Location = new System.Drawing.Point(13, 13);
            this.ChooseFolder.Name = "ChooseFolder";
            this.ChooseFolder.Size = new System.Drawing.Size(98, 31);
            this.ChooseFolder.TabIndex = 0;
            this.ChooseFolder.Text = "Choose Folder";
            this.ChooseFolder.UseVisualStyleBackColor = true;
            this.ChooseFolder.Click += new System.EventHandler(this.ChooseFolder_Click);
            // 
            // FolderPath
            // 
            this.FolderPath.AutoSize = true;
            this.FolderPath.Location = new System.Drawing.Point(130, 21);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(58, 13);
            this.FolderPath.TabIndex = 2;
            this.FolderPath.Text = "FolderPath";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Enabled = false;
            this.ConvertButton.Location = new System.Drawing.Point(12, 346);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(485, 65);
            this.ConvertButton.TabIndex = 3;
            this.ConvertButton.Text = "Convert All Images to PNG";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 417);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(485, 21);
            this.ProgressBar.TabIndex = 4;
            this.ProgressBar.UseWaitCursor = true;
            // 
            // FileList
            // 
            this.FileList.Enabled = false;
            this.FileList.GridLines = true;
            this.FileList.HideSelection = false;
            this.FileList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.FileList.Location = new System.Drawing.Point(13, 50);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(484, 290);
            this.FileList.TabIndex = 5;
            this.FileList.UseCompatibleStateImageBehavior = false;
            this.FileList.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.FolderPath);
            this.Controls.Add(this.ChooseFolder);
            this.Name = "Form1";
            this.Text = "HEIC 2 PNG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseFolder;
        private System.Windows.Forms.Label FolderPath;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.ListView FileList;
    }
}

