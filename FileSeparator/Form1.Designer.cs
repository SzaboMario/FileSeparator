
namespace FileSeparator
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
            this.selectFolderBtn = new System.Windows.Forms.Button();
            this.sourceFolderNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.fileTypeCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.findedFileCountLabel = new System.Windows.Forms.Label();
            this.inspectedCountLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectFolderBtn
            // 
            this.selectFolderBtn.Location = new System.Drawing.Point(322, 59);
            this.selectFolderBtn.Name = "selectFolderBtn";
            this.selectFolderBtn.Size = new System.Drawing.Size(75, 23);
            this.selectFolderBtn.TabIndex = 0;
            this.selectFolderBtn.Text = "Select folder";
            this.selectFolderBtn.UseVisualStyleBackColor = true;
            this.selectFolderBtn.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // sourceFolderNameText
            // 
            this.sourceFolderNameText.Location = new System.Drawing.Point(103, 61);
            this.sourceFolderNameText.Name = "sourceFolderNameText";
            this.sourceFolderNameText.ReadOnly = true;
            this.sourceFolderNameText.Size = new System.Drawing.Size(213, 20);
            this.sourceFolderNameText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "2. Source folder:";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(322, 7);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 48);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Stoped separate";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Program info: Separates files with similar properties from a folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(269, 37);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(47, 13);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Stopped";
            // 
            // fileTypeCombo
            // 
            this.fileTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fileTypeCombo.FormattingEnabled = true;
            this.fileTypeCombo.Items.AddRange(new object[] {
            ".jpg",
            ".gif",
            ".bmp",
            ".png"});
            this.fileTypeCombo.Location = new System.Drawing.Point(125, 34);
            this.fileTypeCombo.Name = "fileTypeCombo";
            this.fileTypeCombo.Size = new System.Drawing.Size(92, 21);
            this.fileTypeCombo.TabIndex = 7;
            this.fileTypeCombo.SelectedIndexChanged += new System.EventHandler(this.fileTypeCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "1. Searched file type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Finded file count:";
            // 
            // findedFileCountLabel
            // 
            this.findedFileCountLabel.AutoSize = true;
            this.findedFileCountLabel.Location = new System.Drawing.Point(106, 84);
            this.findedFileCountLabel.Name = "findedFileCountLabel";
            this.findedFileCountLabel.Size = new System.Drawing.Size(13, 13);
            this.findedFileCountLabel.TabIndex = 10;
            this.findedFileCountLabel.Text = "0";
            // 
            // inspectedCountLabel
            // 
            this.inspectedCountLabel.AutoSize = true;
            this.inspectedCountLabel.Location = new System.Drawing.Point(75, 100);
            this.inspectedCountLabel.Name = "inspectedCountLabel";
            this.inspectedCountLabel.Size = new System.Drawing.Size(13, 13);
            this.inspectedCountLabel.TabIndex = 12;
            this.inspectedCountLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Inspected:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 122);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inspectedCountLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.findedFileCountLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fileTypeCombo);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceFolderNameText);
            this.Controls.Add(this.selectFolderBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File separator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFolderBtn;
        private System.Windows.Forms.TextBox sourceFolderNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox fileTypeCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label findedFileCountLabel;
        private System.Windows.Forms.Label inspectedCountLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

