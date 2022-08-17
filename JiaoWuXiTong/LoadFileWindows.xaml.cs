using JiaoWuXiTong.Core;
using JiaoWuXiTong.DataMode;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JiaoWuXiTong
{
    /// <summary>
    /// LoadFileWindows.xaml 的交互逻辑
    /// </summary>
    public partial class LoadFileWindows : Window
    {
        private ObservableCollection<LoadFileData> list;
        private Config config;
        public LoadFileWindows()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            config = DataManager.Instance.config;
            list = new ObservableCollection<LoadFileData>();
            if (config==null)
            {
                MessageBox.Show("Config.json出现问题,请删掉Config.json文件后重试");
                this.Close();
            }
            else
            {

                if (config.LoadFileData.Count == 0)
                {
                    list.Add(new LoadFileData(1, "教师信息", false));
                    list.Add(new LoadFileData(2, "课程信息", false));
                    config.LoadFileData = list.ToList<LoadFileData>();
                    DataManager.Instance.SaveConfig();
                }
                else
                {
                    for (int i = 0; i < config.LoadFileData.Count; i++)
                    {
                        list.Add(config.LoadFileData[i]);
                    }
                }
                LoadGrid.DataContext = list;
                
            }

        }

        private void LoadFile(object sender, RoutedEventArgs e)
        {
            Button? btn = sender as Button;
            if (btn != null)
            {
                int id = Convert.ToInt32(btn.Tag);
                LoadFileData? data = null;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].ID == id)
                        data = list[i];
                }

                if(data != null)
                {
                    data.OriginalPath = Tools.OpenExcelFile();
                    data.ProjectPath = "Excel/" + new FileInfo(data.OriginalPath).Name;
                    Tools.FileCopy(data.OriginalPath, AppDomain.CurrentDomain.BaseDirectory + "Excel",true);
                    if (!string.IsNullOrEmpty(data.OriginalPath))
                    {
                        data.State = true;
                        btn.Content = "重新导入";
                    }
                    else
                    {
                        data.State = false;
                        btn.Content = "导入";
                    }
                    DataManager.Instance.SaveConfig();
                }

            }
        }
    }
}
