using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// MetadataExtractor - 사진 영상 파일 날짜 리딩 라이브러리
using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using MetadataExtractor.Formats.QuickTime;
// TagLibSharp - 음악 날짜 리딩 라이브러리
using TagLib;



namespace Auto_Foldering
{
    public partial class Form2 : Form
    {
        // form1 디렉토리
        private string[] receivedFiles;
        private string selectedDirectory;
        private string toSaveLoc;

        public Form2()
        {
            InitializeComponent();
            this.Icon = new Icon("icon.ico");
        }

        public Form2(string[] files, string directory)
        {
            InitializeComponent();
            this.Icon = new Icon("icon.ico");
            receivedFiles = files;
            selectedDirectory = directory;
            toSaveLoc = directory;

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
            if (fbd.ShowDialog() == DialogResult.OK)
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
                e.Handled = true; // 입력 무시
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

        private void btnExecute_Click(object sender, EventArgs e)
        {
            /*
             대표 >> 연간 체크 케이스
            1. 파일의 시간을 읽는다. (촬영일자 우선, 없으면 생성일자)
            2. 연간을 뽑아낸다.
            3. 폴더를 만든다 (없으면 생성, 있으면 유지)
            4. 폴더 경로에 파일을 넣는다.
             */
            if (radYear.Checked)
            {
                foreach (string file in receivedFiles)
                {
                    // 기존 방식 (생성일 기준)
                    // DateTime createTime = File.GetCreationTime(file);
                    // string year = createTime.ToString("yyyy");

                    // 수정: 원본(촬영)일자 → 없으면 생성일자
                    DateTime useTime = GetDateTakenOrCreated(file);
                    string year = useTime.ToString("yyyy");

                    string folderPath = Path.Combine(toSaveLoc, year);
                    string fileName = Path.GetFileName(file);
                    string targetPath = Path.Combine(folderPath, fileName);

                    System.IO.Directory.CreateDirectory(folderPath);
                    System.IO.File.Copy(file, targetPath, overwrite: true);
                }
                // 종료
                MessageBox.Show("완료되었습니다.");
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();  // Form2 닫기
            }
        }

        private DateTime GetDateTakenOrCreated(string path)
        {
            try
            {
                var directories = ImageMetadataReader.ReadMetadata(path);

                var exif = directories.OfType<ExifSubIfdDirectory>().FirstOrDefault();
                if (exif != null && exif.TryGetDateTime(ExifDirectoryBase.TagDateTimeOriginal, out DateTime exifDate))
                    return exifDate;

                var quickTime = directories.OfType<QuickTimeMovieHeaderDirectory>().FirstOrDefault();
                if (quickTime != null && quickTime.TryGetDateTime(QuickTimeMovieHeaderDirectory.TagCreated, out DateTime videoDate))
                    return videoDate;
            }
            catch
            {
                // MetadataExtractor 실패 시 무시
            }

            // TagLib으로 음악 날짜 추출
            try
            {
                var audioFile = TagLib.File.Create(path);
                if (audioFile.Tag.Year > 0)
                    return new DateTime((int)audioFile.Tag.Year, 1, 1);
            }
            catch
            {
                // 음악 파일 아님
            }

            return System.IO.File.GetCreationTime(path);
        }
    }
}
