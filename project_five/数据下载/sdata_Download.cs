using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_five
{
    public partial class sdata_Download : Form
    {
        public sdata_Download()
        {
            InitializeComponent();
        }

        private void btnFormat_intro_Click(object sender, EventArgs e)
        {
            this.palFormat_Intro.Visible = true;
            this.palFile_Dload.Visible = false;
            this.palCopyright.Visible = false;
            this.palFormat_Intro.BringToFront();
            palFormat_Intro.Location = palFile_Dload.Location;//让位置相等
        }

        private void btnData_Download_Click(object sender, EventArgs e)
        {
            this.palFile_Dload.Visible = true;
            this.palFormat_Intro.Visible = false;
            this.palCopyright.Visible = false;
            this.palFile_Dload.BringToFront();
            palFile_Dload.Location = palFile_Dload.Location;//让位置相等
        }

        private void btnCopyright_Click(object sender, EventArgs e)
        {
            this.palCopyright.Visible = true;
            this.palFormat_Intro.Visible = false;
            this.palFile_Dload.Visible = false;
            this.palCopyright.BringToFront();
            palCopyright.Location = palFile_Dload.Location;//让位置相等
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDLoad1_Click(object sender, EventArgs e)
        {
            var frm = new Download();
            frm.ShowDialog();
        }

        private void btnDLoad2_Click(object sender, EventArgs e)
        {
            var frm = new Download();
            frm.ShowDialog();
        }

        private void btnDLoad3_Click(object sender, EventArgs e)
        {
            var frm = new Download();
            frm.ShowDialog();
        }
    }
}
