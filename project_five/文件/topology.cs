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
    public partial class topology : Form
    {
        public topology()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad1_Click(object sender, EventArgs e)
        {
            //var frm = new topo_Introduction();
            //frm.ShowDialog();
        }

        private void btnLoad2_Click(object sender, EventArgs e)
        {
            //var frm = new topo_Introduction();
            //frm.ShowDialog();
        }

        private void btnLoad3_Click(object sender, EventArgs e)
        {
            //var frm = new topo_Introduction();
            //frm.ShowDialog();
        }

        private void btnTopo_intro_Click(object sender, EventArgs e)
        {
            var frm = new topo_Introduction();
            frm.ShowDialog();
        }

        private void btnData_load_Click(object sender, EventArgs e)
        {
            var frm = new data_Load();
            frm.ShowDialog();
        }
    }
}
