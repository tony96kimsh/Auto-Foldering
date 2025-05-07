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
    public partial class Form1: Form
    {
        string directory;
        string[] files;
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnOpenFold_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                directory = fbd.SelectedPath;
                MessageBox.Show(directory);

                // Form2로 전환
                Form2 form2 = new Form2();
                form2.Show();     // 새 폼을 띄우고
                this.Hide();      // 현재 Form1을 숨김 (닫지는 않음)
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.FileNames;
                MessageBox.Show(string.Join("\n", files));

                // Form2로 전환
                Form2 form2 = new Form2();
                form2.Show();     // 새 폼을 띄우고
                this.Hide();      // 현재 Form1을 숨김 (닫지는 않음)
            }
        }
    }
}
