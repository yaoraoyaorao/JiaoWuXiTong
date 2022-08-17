using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace JiaoWuXiTong.Core
{
    public class Tools
    {
        public static string OpenExcelFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Excel";
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            openFileDialog.InitialDirectory = path;
            openFileDialog.Filter = "Excel文件(*.xls)|*.xls|Excel文件(*.xlsx)|*.xlsx";
            openFileDialog.Title = AppDomain.CurrentDomain.BaseDirectory + "/Excel";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return string.Empty;
        }

        public static void FileCopy(string source,string target,bool isrewrite)
        {
            FileInfo fileInfo = new FileInfo(source);

            if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(target))
            {
                return;
            }
            else if(source == target + "/" + fileInfo.Name)
            {
                return;
            }
            
            fileInfo.CopyTo(target + "/" + fileInfo.Name,isrewrite);
        }

    }
}
