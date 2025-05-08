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
            this.radYear = new System.Windows.Forms.RadioButton();
            this.radMonth = new System.Windows.Forms.RadioButton();
            this.radDay = new System.Windows.Forms.RadioButton();
            this.radWeek = new System.Windows.Forms.RadioButton();
            this.radFileUnit = new System.Windows.Forms.RadioButton();
            this.inpFileUnit = new System.Windows.Forms.TextBox();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.lblOrgLoc = new System.Windows.Forms.Label();
            this.btnChangeSave = new System.Windows.Forms.Button();
            this.lblSaveLoc = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPlaceholder = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(20, 21);
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
            this.label1.Location = new System.Drawing.Point(106, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "정리 형식 선택하기";
            // 
            // radYear
            // 
            this.radYear.AutoSize = true;
            this.radYear.Checked = true;
            this.radYear.Font = new System.Drawing.Font("Noto Sans KR", 12.2F);
            this.radYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radYear.Location = new System.Drawing.Point(45, 325);
            this.radYear.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radYear.Name = "radYear";
            this.radYear.Size = new System.Drawing.Size(85, 29);
            this.radYear.TabIndex = 5;
            this.radYear.TabStop = true;
            this.radYear.Text = "년 Year";
            this.radYear.UseVisualStyleBackColor = true;
            // 
            // radMonth
            // 
            this.radMonth.AutoSize = true;
            this.radMonth.BackColor = System.Drawing.Color.Transparent;
            this.radMonth.Font = new System.Drawing.Font("Noto Sans KR", 12.2F);
            this.radMonth.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radMonth.Location = new System.Drawing.Point(158, 325);
            this.radMonth.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radMonth.Name = "radMonth";
            this.radMonth.Size = new System.Drawing.Size(101, 29);
            this.radMonth.TabIndex = 6;
            this.radMonth.TabStop = true;
            this.radMonth.Text = "월 Month";
            this.radMonth.UseVisualStyleBackColor = false;
            this.radMonth.CheckedChanged += new System.EventHandler(this.radMonth_CheckedChanged);
            // 
            // radDay
            // 
            this.radDay.AutoSize = true;
            this.radDay.Font = new System.Drawing.Font("Noto Sans KR", 12.2F);
            this.radDay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radDay.Location = new System.Drawing.Point(418, 325);
            this.radDay.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radDay.Name = "radDay";
            this.radDay.Size = new System.Drawing.Size(82, 29);
            this.radDay.TabIndex = 7;
            this.radDay.TabStop = true;
            this.radDay.Text = "일 Day";
            this.radDay.UseVisualStyleBackColor = true;
            this.radDay.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radWeek
            // 
            this.radWeek.AutoSize = true;
            this.radWeek.Font = new System.Drawing.Font("Noto Sans KR", 12.2F);
            this.radWeek.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radWeek.Location = new System.Drawing.Point(293, 325);
            this.radWeek.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radWeek.Name = "radWeek";
            this.radWeek.Size = new System.Drawing.Size(93, 29);
            this.radWeek.TabIndex = 8;
            this.radWeek.TabStop = true;
            this.radWeek.Text = "주 Week";
            this.radWeek.UseVisualStyleBackColor = true;
            this.radWeek.CheckedChanged += new System.EventHandler(this.radWeek_CheckedChanged);
            // 
            // radFileUnit
            // 
            this.radFileUnit.AutoSize = true;
            this.radFileUnit.Font = new System.Drawing.Font("Noto Sans KR", 12.2F);
            this.radFileUnit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radFileUnit.Location = new System.Drawing.Point(44, 384);
            this.radFileUnit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radFileUnit.Name = "radFileUnit";
            this.radFileUnit.Size = new System.Drawing.Size(168, 29);
            this.radFileUnit.TabIndex = 11;
            this.radFileUnit.TabStop = true;
            this.radFileUnit.Text = "파일 개수로 나누기";
            this.radFileUnit.UseVisualStyleBackColor = true;
            this.radFileUnit.CheckedChanged += new System.EventHandler(this.radFileUnit_CheckedChanged);
            // 
            // inpFileUnit
            // 
            this.inpFileUnit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.inpFileUnit.Location = new System.Drawing.Point(223, 104);
            this.inpFileUnit.MaxLength = 10;
            this.inpFileUnit.Name = "inpFileUnit";
            this.inpFileUnit.ReadOnly = true;
            this.inpFileUnit.Size = new System.Drawing.Size(265, 38);
            this.inpFileUnit.TabIndex = 12;
            this.inpFileUnit.Enter += new System.EventHandler(this.inpFileUnit_Enter);
            this.inpFileUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inpFileUnit_KeyPress);
            this.inpFileUnit.Leave += new System.EventHandler(this.inpFileUnit_Leave);
            // 
            // lblOrgLoc
            // 
            this.lblOrgLoc.AutoSize = true;
            this.lblOrgLoc.Font = new System.Drawing.Font("Noto Sans KR", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrgLoc.Location = new System.Drawing.Point(118, 112);
            this.lblOrgLoc.Name = "lblOrgLoc";
            this.lblOrgLoc.Size = new System.Drawing.Size(162, 24);
            this.lblOrgLoc.TabIndex = 14;
            this.lblOrgLoc.Text = ".../test/test/tes.testst";
            // 
            // btnChangeSave
            // 
            this.btnChangeSave.Location = new System.Drawing.Point(428, 166);
            this.btnChangeSave.Name = "btnChangeSave";
            this.btnChangeSave.Size = new System.Drawing.Size(89, 39);
            this.btnChangeSave.TabIndex = 16;
            this.btnChangeSave.Text = "변경";
            this.btnChangeSave.UseVisualStyleBackColor = true;
            this.btnChangeSave.Click += new System.EventHandler(this.btnChangeSave_Click);
            // 
            // lblSaveLoc
            // 
            this.lblSaveLoc.AutoSize = true;
            this.lblSaveLoc.Font = new System.Drawing.Font("Noto Sans KR", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveLoc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSaveLoc.Location = new System.Drawing.Point(118, 173);
            this.lblSaveLoc.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblSaveLoc.Name = "lblSaveLoc";
            this.lblSaveLoc.Size = new System.Drawing.Size(178, 24);
            this.lblSaveLoc.TabIndex = 18;
            this.lblSaveLoc.Text = ".../test/test/tes.testst";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(485, 124);
            this.button2.TabIndex = 19;
            this.button2.Text = "실행";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans KR Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "정리 파일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans KR Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 27);
            this.label3.TabIndex = 21;
            this.label3.Text = "저장 위치";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPlaceholder);
            this.groupBox1.Controls.Add(this.inpFileUnit);
            this.groupBox1.Font = new System.Drawing.Font("Noto Sans KR", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 167);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "정리 방식을 선택해주세요.";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblPlaceholder
            // 
            this.lblPlaceholder.AutoSize = true;
            this.lblPlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaceholder.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPlaceholder.Location = new System.Drawing.Point(225, 108);
            this.lblPlaceholder.Name = "lblPlaceholder";
            this.lblPlaceholder.Size = new System.Drawing.Size(190, 30);
            this.lblPlaceholder.TabIndex = 23;
            this.lblPlaceholder.Text = "숫자만 입력해주세요";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 651);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblSaveLoc);
            this.Controls.Add(this.btnChangeSave);
            this.Controls.Add(this.lblOrgLoc);
            this.Controls.Add(this.radFileUnit);
            this.Controls.Add(this.radWeek);
            this.Controls.Add(this.radDay);
            this.Controls.Add(this.radMonth);
            this.Controls.Add(this.radYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Noto Sans KR", 14.2F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radYear;
        private System.Windows.Forms.RadioButton radMonth;
        private System.Windows.Forms.RadioButton radDay;
        private System.Windows.Forms.RadioButton radWeek;
        private System.Windows.Forms.RadioButton radFileUnit;
        private System.Windows.Forms.TextBox inpFileUnit;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Label lblOrgLoc;
        private System.Windows.Forms.Button btnChangeSave;
        private System.Windows.Forms.Label lblSaveLoc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPlaceholder;
    }
}