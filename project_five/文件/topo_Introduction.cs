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
    public partial class topo_Introduction : Form
    {
        public topo_Introduction()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_109_Click(object sender, EventArgs e)
        {
            this.pal_109.Visible = true;
            this.pal_39.Visible = false;
            this.pal_66.Visible = false;
            this.pal_109.BringToFront();
        }

        private void btn_39_Click(object sender, EventArgs e)
        {
            this.pal_109.Visible = false;
            this.pal_39.Visible = true;
            this.pal_66.Visible = false;
            this.pal_39.BringToFront();
        }

        private void btn_66_Click(object sender, EventArgs e)
        {
            this.pal_109.Visible = false;
            this.pal_39.Visible = false;
            this.pal_66.Visible = true;
            this.pal_66.BringToFront();
        }
    }
}
