using System;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_five
{
    public class Folder_Manipulate
    {
        /// <summary>
        /// 得到文件夹中*.txt文件的个数
        /// </summary>
        /// <param pattern="*.txt">读取的文件类型</param>
        /// <param name="dirPath">文件夹路径</param>
        public static int GetFilesCount(DirectoryInfo dirInfo)
        {
            int totalFile = 0;                                         //定义totalFile
            totalFile += dirInfo.GetFiles("*.txt").Length;             //totalfile为*.txt格式文件个数
            foreach (DirectoryInfo subdir in dirInfo.GetDirectories()) //读取文件夹中*.txt个数？？
            {
                totalFile += GetFilesCount(subdir);                    
            }
            return totalFile;
        }
    }
}
