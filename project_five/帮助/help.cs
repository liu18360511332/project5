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
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void manual_instru_Click(object sender, EventArgs e)
        {
            this.pal_manual.Visible = true;
            this.pal_manual_dowl.Visible = false;
            this.pal_manual.BringToFront();
        }

        private void manual_download_Click(object sender, EventArgs e)
        {
            this.pal_manual.Visible = false;
            this.pal_manual_dowl.Visible = false;
            var frm = new manual_save();
            frm.ShowDialog();
        }

        private void about_us_Click(object sender, EventArgs e)
        {
            this.pal_aboout_use.Visible = true;
            this.pal_manual.Visible = false;
            this.pal_aboout_use.Location = this.pal_manual.Location;
            this.pal_aboout_use.BringToFront();
        }
    }
}
