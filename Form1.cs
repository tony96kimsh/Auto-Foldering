
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using System.Windows.Forms;
using System.IO;

namespace Auto_Foldering
{
    public partial class Form1: Form
    {
        string directory;
        string[] files;
        public Form1()
        {
            InitializeComponent();
            this.Icon = new Icon("icon.ico");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 설명서 링크
            string url = "https://github.com/tony96kimsh/Auto-Foldering/blob/main/%EC%82%AC%EC%9A%A9%EB%B0%A9%EB%B2%95.md";

            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("링크를 열 수 없습니다." + ex.Message);
            }
        }

        private void btnOpenFold_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                directory = fbd.SelectedPath;
                files = Directory.GetFiles(directory);

                //MessageBox.Show(string.Join("\n", files));
                //MessageBox.Show(directory);

                // Form2로 전환
                Form2 form2 = new Form2(files, directory);
                form2.Show();
                this.Hide();
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.FileNames;
                directory = Path.GetDirectoryName(files[0]);

                //MessageBox.Show(string.Join("\n", files));
                //MessageBox.Show(directory);

                // Form2로 전환
                Form2 form2 = new Form2(files, directory);
                form2.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
