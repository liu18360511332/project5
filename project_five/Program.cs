using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_five
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            login_page login_page = new login_page();
            login_page.ShowDialog();
            if (login_page.DialogResult == DialogResult.OK)
            {
                login_page.Dispose();
                Application.Run(new main_page());
            }
            else if (login_page.DialogResult == DialogResult.Cancel)
            {
                login_page.Dispose();
                return;
            }
        }
    }
}
