using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Foldering
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveDirectory_Click(object sender, EventArgs e)
        {
            if(fbd.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();  // Form2 닫기
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
