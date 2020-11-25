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
    public partial class data_Load : Form
    {
        public data_Load()
        {
            InitializeComponent();
        }

        private void btnTopo_intro_Click(object sender, EventArgs e)
        {
            var frm = new data_Introduction();
            frm.ShowDialog();
        }

        private void btnset_Click(object sender, EventArgs e)
        {
            var frm = new custom_Data();
            frm.ShowDialog();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad1_Click(object sender, EventArgs e)
        {

        }
    }
}
