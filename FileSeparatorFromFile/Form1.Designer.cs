
namespace FileSeparatorFromFile
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
            this.sourceFolderBtn = new System.Windows.Forms.Button();
            this.sourceFolderTextBox = new System.Windows.Forms.TextBox();
            this.S = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.targetFolderTextBox = new System.Windows.Forms.TextBox();
            this.targetFolderBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fileCounterLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.separationFileTextBox = new System.Windows.Forms.TextBox();
            this.openSeparationFileBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.copyFileCountLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.separationListCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sourceFolderBtn
            // 
            this.sourceFolderBtn.Location = new System.Drawing.Point(387, 9);
            this.sourceFolderBtn.Name = "sourceFolderBtn";
            this.sourceFolderBtn.Size = new System.Drawing.Size(134, 24);
            this.sourceFolderBtn.TabIndex = 0;
            this.sourceFolderBtn.Text = "Select source folder";
            this.sourceFolderBtn.UseVisualStyleBackColor = true;
            this.sourceFolderBtn.Click += new System.EventHandler(this.sourceFolderBtn_Click);
            // 
            // sourceFolderTextBox
            // 
            this.sourceFolderTextBox.Location = new System.Drawing.Point(110, 12);
            this.sourceFolderTextBox.Name = "sourceFolderTextBox";
            this.sourceFolderTextBox.ReadOnly = true;
            this.sourceFolderTextBox.Size = new System.Drawing.Size(271, 20);
            this.sourceFolderTextBox.TabIndex = 1;
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Location = new System.Drawing.Point(12, 15);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(73, 13);
            this.S.TabIndex = 2;
            this.S.Text = "Source folder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Destination folder:";
            // 
            // targetFolderTextBox
            // 
            this.targetFolderTextBox.Location = new System.Drawing.Point(110, 38);
            this.targetFolderTextBox.Name = "targetFolderTextBox";
            this.targetFolderTextBox.ReadOnly = true;
            this.targetFolderTextBox.Size = new System.Drawing.Size(271, 20);
            this.targetFolderTextBox.TabIndex = 4;
            // 
            // targetFolderBtn
            // 
            this.targetFolderBtn.Location = new System.Drawing.Point(387, 35);
            this.targetFolderBtn.Name = "targetFolderBtn";
            this.targetFolderBtn.Size = new System.Drawing.Size(134, 24);
            this.targetFolderBtn.TabIndex = 3;
            this.targetFolderBtn.Text = "Select destination folder";
            this.targetFolderBtn.UseVisualStyleBackColor = true;
            this.targetFolderBtn.Click += new System.EventHandler(this.targetFolderBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Tomato;
            this.startBtn.Location = new System.Drawing.Point(387, 91);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(134, 38);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Checked file counter:";
            // 
            // fileCounterLabel
            // 
            this.fileCounterLabel.AutoSize = true;
            this.fileCounterLabel.Location = new System.Drawing.Point(126, 91);
            this.fileCounterLabel.Name = "fileCounterLabel";
            this.fileCounterLabel.Size = new System.Drawing.Size(24, 13);
            this.fileCounterLabel.TabIndex = 10;
            this.fileCounterLabel.Text = "0/0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Separation file:";
            // 
            // separationFileTextBox
            // 
            this.separationFileTextBox.Location = new System.Drawing.Point(110, 64);
            this.separationFileTextBox.Name = "separationFileTextBox";
            this.separationFileTextBox.ReadOnly = true;
            this.separationFileTextBox.Size = new System.Drawing.Size(271, 20);
            this.separationFileTextBox.TabIndex = 13;
            // 
            // openSeparationFileBtn
            // 
            this.openSeparationFileBtn.Location = new System.Drawing.Point(387, 61);
            this.openSeparationFileBtn.Name = "openSeparationFileBtn";
            this.openSeparationFileBtn.Size = new System.Drawing.Size(134, 24);
            this.openSeparationFileBtn.TabIndex = 12;
            this.openSeparationFileBtn.Text = "Select separation file";
            this.openSeparationFileBtn.UseVisualStyleBackColor = true;
            this.openSeparationFileBtn.Click += new System.EventHandler(this.openSeparationFileBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Copied file counter:";
            // 
            // copyFileCountLabel
            // 
            this.copyFileCountLabel.AutoSize = true;
            this.copyFileCountLabel.Location = new System.Drawing.Point(311, 91);
            this.copyFileCountLabel.Name = "copyFileCountLabel";
            this.copyFileCountLabel.Size = new System.Drawing.Size(13, 13);
            this.copyFileCountLabel.TabIndex = 16;
            this.copyFileCountLabel.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 25);
            this.button1.TabIndex = 17;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Separation list counter:";
            // 
            // separationListCountLabel
            // 
            this.separationListCountLabel.AutoSize = true;
            this.separationListCountLabel.Location = new System.Drawing.Point(126, 115);
            this.separationListCountLabel.Name = "separationListCountLabel";
            this.separationListCountLabel.Size = new System.Drawing.Size(13, 13);
            this.separationListCountLabel.TabIndex = 19;
            this.separationListCountLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 137);
            this.Controls.Add(this.separationListCountLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.copyFileCountLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.separationFileTextBox);
            this.Controls.Add(this.openSeparationFileBtn);
            this.Controls.Add(this.fileCounterLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.targetFolderTextBox);
            this.Controls.Add(this.targetFolderBtn);
            this.Controls.Add(this.S);
            this.Controls.Add(this.sourceFolderTextBox);
            this.Controls.Add(this.sourceFolderBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileCollector from file";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sourceFolderBtn;
        private System.Windows.Forms.TextBox sourceFolderTextBox;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox targetFolderTextBox;
        private System.Windows.Forms.Button targetFolderBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fileCounterLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox separationFileTextBox;
        private System.Windows.Forms.Button openSeparationFileBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label copyFileCountLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label separationListCountLabel;
    }
}

