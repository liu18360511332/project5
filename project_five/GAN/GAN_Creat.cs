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
    public partial class GAN_Creat : Form
    {
        public GAN_Creat()
        {
            InitializeComponent();
        }

        private void 导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new data_Input();
            frm.ShowDialog();
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Saveas();
            frm.ShowDialog();
        }
    }
}
