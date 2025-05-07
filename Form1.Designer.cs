namespace Auto_Foldering
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenFold = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "정리를 원하는 파일을 선택해주세요";
            // 
            // btnOpenFold
            // 
            this.btnOpenFold.Location = new System.Drawing.Point(17, 123);
            this.btnOpenFold.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenFold.Name = "btnOpenFold";
            this.btnOpenFold.Size = new System.Drawing.Size(223, 131);
            this.btnOpenFold.TabIndex = 1;
            this.btnOpenFold.Text = "📂 폴더 선택";
            this.btnOpenFold.UseVisualStyleBackColor = true;
            this.btnOpenFold.Click += new System.EventHandler(this.btnOpenFold_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Noto Sans KR", 12F);
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.Location = new System.Drawing.Point(19, 340);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(193, 29);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "사용법 및 개발 사이트";
            this.linkLabel1.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(257, 123);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(223, 131);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.Text = "📃 파일 선택";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 399);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnOpenFold);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Noto Sans KR", 16F);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Form1";
            this.Text = "Auto Foldering | 자동 파일 정리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenFold;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

