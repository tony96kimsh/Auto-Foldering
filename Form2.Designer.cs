namespace Auto_Foldering
{
    partial class Form2
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSaveDirectory = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(20, 20);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(69, 69);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans KR", 24.2F);
            this.label1.Location = new System.Drawing.Point(106, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "정리 형식 선택하기";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans KR", 16.2F);
            this.label4.Location = new System.Drawing.Point(42, 319);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "정리 방식을 선택해주세요.";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Noto Sans KR", 12.2F);
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton1.Location = new System.Drawing.Point(49, 378);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 34);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "년 Year";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Noto Sans KR", 12.2F);
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioButton2.Location = new System.Drawing.Point(162, 378);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(123, 34);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "월 Month";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Noto Sans KR", 12.2F);
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioButton3.Location = new System.Drawing.Point(422, 378);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(96, 34);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.Text = "일 Day";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Noto Sans KR", 12.2F);
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioButton4.Location = new System.Drawing.Point(297, 378);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(113, 34);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.Text = "주 Week";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Noto Sans KR", 12.2F);
            this.radioButton5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioButton5.Location = new System.Drawing.Point(48, 437);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(198, 34);
            this.radioButton5.TabIndex = 11;
            this.radioButton5.Text = "파일 개수로 나누기";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 433);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 42);
            this.textBox1.TabIndex = 12;
            // 
            // btnSaveDirectory
            // 
            this.btnSaveDirectory.Location = new System.Drawing.Point(39, 116);
            this.btnSaveDirectory.Name = "btnSaveDirectory";
            this.btnSaveDirectory.Size = new System.Drawing.Size(89, 51);
            this.btnSaveDirectory.TabIndex = 13;
            this.btnSaveDirectory.Text = "변경";
            this.btnSaveDirectory.UseVisualStyleBackColor = true;
            this.btnSaveDirectory.Click += new System.EventHandler(this.btnSaveDirectory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "대상 파일: .../test/test/tes.testst";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 51);
            this.button1.TabIndex = 16;
            this.button1.Text = "변경";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 35);
            this.label3.TabIndex = 18;
            this.label3.Text = "저장위치: .../test/test/tes.testst";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(485, 125);
            this.button2.TabIndex = 19;
            this.button2.Text = "실행";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 688);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveDirectory);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Noto Sans KR", 14.2F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSaveDirectory;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}