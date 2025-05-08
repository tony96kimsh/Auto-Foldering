using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Auto_Foldering
{
    public partial class Form2: Form
    {
        // form1 디렉토리
        private string[] receivedFiles;
        private string selectedDirectory;
        private string toSaveLoc;

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string[] files, string directory)
        {
            InitializeComponent();
            receivedFiles = files;
            selectedDirectory = directory;
            
            //if (receivedFiles != null && receivedFiles.Length > 0)
            //    MessageBox.Show("첫 파일: " + receivedFiles[0]);
            //if (!string.IsNullOrEmpty(selectedDirectory))
            //    MessageBox.Show("선택된 폴더: " + selectedDirectory);

            lblOrgLoc.Text = selectedDirectory;
            lblSaveLoc.Text = selectedDirectory;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is RadioButton rb)
                {
                    rb.CheckedChanged += RadioButton_CheckedChanged;
                }

                // 혹시 GroupBox 안에 라디오버튼이 있다면 추가 검사
                if (ctrl is GroupBox gb)
                {
                    foreach (Control inner in gb.Controls)
                    {
                        if (inner is RadioButton rbInner)
                        {
                            rbInner.CheckedChanged += RadioButton_CheckedChanged;
                        }
                    }
                }
            }
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selected = sender as RadioButton;

            if (selected != null)
            {
                selected.ForeColor = selected.Checked
                    ? SystemColors.ActiveCaptionText     // 강조색
                    : SystemColors.ControlDarkDark;      // 기본/비활성 색
            }
        }



        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();  // Form2 닫기
        }


        private void btnChangeSave_Click(object sender, EventArgs e)
        {
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                toSaveLoc = fbd.SelectedPath;
                lblSaveLoc.Text = toSaveLoc;
            }
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radMonth_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radWeek_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radFileUnit_CheckedChanged(object sender, EventArgs e)
        {
            inpFileUnit.ReadOnly = false;
            inpFileUnit.Focus();
            lblPlaceholder.Visible = false;
        }

        private void inpFileUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자(0~9)와 백스페이스만 허용
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // 입력 무시a
            }
        }

        private void inpFileUnit_Leave(object sender, EventArgs e)
        {
            string placeholderText = "숫자를 입력하세요";
            if (string.IsNullOrWhiteSpace(inpFileUnit.Text))
            {
                inpFileUnit.Text = placeholderText;
                inpFileUnit.ForeColor = Color.Gray;
            }
        }

        private void inpFileUnit_Enter(object sender, EventArgs e)
        {
            string placeholderText = "숫자를 입력하세요";
            if (inpFileUnit.Text == placeholderText)
            {
                inpFileUnit.Text = "";
                inpFileUnit.ForeColor = Color.Black;
            }
        }
    }
}
