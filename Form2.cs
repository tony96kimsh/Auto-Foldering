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

        private bool isExiting = false;
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
            MessageBox.Show("주간 선택 시, 월요일부터 일요일 기준으로 정리됩니다. \n 폴더 형식 \"yyyy-MM-dd_yyyy-MM-dd\" ");
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
            if (receivedFiles == null || receivedFiles.Length == 0)
            {
                MessageBox.Show("파일이 선택되지 않았습니다.");
                return;
            }

            foreach (string file in receivedFiles)
            {
                DateTime useTime = GetDateTakenOrCreated(file);
                string folderName = "";

                string folderPath = Path.Combine(toSaveLoc, folderName);
                string fileName = Path.GetFileName(file);
                string targetPath = Path.Combine(folderPath, fileName);

                if (radYear.Checked)
                {
                    folderName = useTime.ToString("yyyy");
                }
                else if (radMonth.Checked)
                {
                    folderName = useTime.ToString("yyyy-MM");
                }
                else if (radWeek.Checked)
                {
                    // 주간 해당 주 월요일 ~ 일요일 기준 구분

                    // 현재 날짜에서 해당 주의 월요일 구함
                    int diff = (7 + (useTime.DayOfWeek - DayOfWeek.Monday)) % 7;
                    DateTime monday = useTime.AddDays(-1 * diff).Date;
                    DateTime sunday = monday.AddDays(6);

                    folderName = $"{monday:yyyy-MM-dd}_{sunday:MM-dd}";
                }
                else if (radDay.Checked)
                {
                    folderName = useTime.ToString("yyyy-MM-dd");
                }

                // 갯수별 구분
                else if (radFileUnit.Checked)
                {
                    if (!int.TryParse(inpFileUnit.Text, out int unit) || unit <= 0)
                    {
                        MessageBox.Show("1 이상의 정수를 입력해주세요.");
                        return;
                    }

                    // 파일을 날짜 기준으로 정렬
                    var sorted = receivedFiles
                        .Select(f => new { File = f, Date = GetDateTakenOrCreated(f) })
                        .OrderBy(x => x.Date)
                        .ToList();

                    for (int i = 0; i < sorted.Count; i += unit)
                    {
                        var group = sorted.Skip(i).Take(unit).ToList();
                        var start = group.First().Date;
                        var end = group.Last().Date;
                        folderName = $"{start:yyyy_MM_dd}_{end:yyyy_MM_dd}";
                        folderPath = Path.Combine(toSaveLoc, folderName);

                        System.IO.Directory.CreateDirectory(folderPath);

                        foreach (var item in group)
                        {
                            fileName = Path.GetFileName(item.File);
                            targetPath = Path.Combine(folderPath, fileName);
                            System.IO.File.Copy(item.File, targetPath, overwrite: true);
                        }
                    }
                }

                else
                {
                    MessageBox.Show("정리 기준을 선택해주세요.");
                    return;
                }



                System.IO.Directory.CreateDirectory(folderPath);
                System.IO.File.Copy(file, targetPath, overwrite: true);
            }

            MessageBox.Show("완료되었습니다.");

            // 탐색기에서 정리된 폴더 경로 열기
            try
            {
                // 현재 폼이 있는 스크린의 위치를 기준으로 탐색기 실행
                var screen = Screen.FromControl(this);
                var folder = toSaveLoc;

                // 탐색기 실행
                Process.Start("explorer.exe", folder);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"탐색기를 여는 도중 오류가 발생했습니다: {ex.Message}");
            }

            // 폼 첫 화면 전환
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
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

        
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExiting) return;  // 이미 종료 중이면 중복 확인 방지

            DialogResult result = MessageBox.Show("정말 종료하시겠습니까?", "종료 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                isExiting = true;
                Application.Exit();  // 여기서 다시 FormClosing이 호출될 수 있음 → 위에서 차단
            }
        }
    }
}
