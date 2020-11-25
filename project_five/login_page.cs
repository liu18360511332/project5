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
    public partial class login_page : Form
    {
        public login_page()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string userName = this.zhanghao.Text;
            string userPassword = this.mima.Text;
            if (this.zhanghao.Text.Trim() == "123" && this.mima.Text.Trim() == "456")
            {
                MessageBox.Show("登录成功");
                this.DialogResult = DialogResult.OK;
                this.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误", "信息提示");
            }
        }
    }
}
