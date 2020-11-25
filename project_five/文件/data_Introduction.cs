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
    public partial class data_Introduction : Form
    {
        public data_Introduction()
        {
            InitializeComponent();
        }

        private void btn_pre_data_Click(object sender, EventArgs e)
        {
            this.pal_pre_dada.Visible = true;
            this.pal_GAN_generate.Visible = false;
            this.pal_self_defining.Visible = false;
            this.pal_pre_dada.BringToFront();
        }

        private void btn_GAN_generate_Click(object sender, EventArgs e)
        {
            this.pal_GAN_generate.Visible = true;
            this.pal_pre_dada.Visible = false;
            this.pal_self_defining.Visible = false;
            this.pal_GAN_generate.Location = this.pal_pre_dada.Location;
            this.pal_GAN_generate.BringToFront();
        }

        private void btn_self_defining_Click(object sender, EventArgs e)
        {
            this.pal_self_defining.Visible = true;
            this.pal_pre_dada.Visible = false;
            this.pal_GAN_generate.Visible = false;
            
            this.pal_self_defining.Location = this.pal_pre_dada.Location;
            this.pal_self_defining.BringToFront();
        }
    }
}
