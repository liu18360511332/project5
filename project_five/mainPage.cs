using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;


namespace project_five
{
    public partial class main_page : Form
    {
        public main_page()
        {
            InitializeComponent();
        }

        private void 加载拓扑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new topology();
            frm.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 自定义参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new parameter_design();
            frm.ShowDialog();
        }

        private void 结果显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new result_show();
            frm.ShowDialog();
        }

        private void gAN生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new GAN_Creat();
            frm.ShowDialog();
        }

        private void 数据下载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new sdata_Download();
            frm.ShowDialog();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new help();
            frm.ShowDialog();
        }

        private void 加载数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm =new data_Load();
            frm.ShowDialog();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Process proc = null;
            try
            {
                string targetDir = string.Format(@"D:\");                   //bat文件的位置
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = "1.bat";                          //bat文件的名字
                proc.StartInfo.Arguments = string.Format("10");             //this is argument
                //proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;    //这里设置DOS窗口不显示，经实践可行
                proc.Start();

               Thread.Sleep(5000);//等待5秒
                //循环读
                while (true)
                {
                    //文件夹的路径
                    string dirPath = @"E:\matlab\bin\chaoliu";
                    //将DirectoryInfo类实例化
                    DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
                    //读取文件夹中txt文件的个数
                    int result = Folder_Manipulate.GetFilesCount(dirInfo);
                    //txt文件未生成结束，等待0.5秒
                    if(result!=6)
                    {
                        Thread.Sleep(500);
                    }
                    else
                    //txt文件生成结束，退出循环
                    {
                        break;
                    }
                }
                //显示“运行结束”
                MessageBox.Show("运行结束");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
            }
        }
    }
}
