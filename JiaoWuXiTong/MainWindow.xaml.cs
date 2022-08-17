using JiaoWuXiTong.Core;
using JiaoWuXiTong.DataMode;
using JsonTool;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JiaoWuXiTong
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Course> c;

        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //c = DataManager.Instance.courses;
            //c.Add(new Course(001, "数学"));
            //c.Add(new Course(002, "语文"));
            //c.Add(new Course(003, "英语"));
            //c.Add(new Course(004, "体育"));
            //DataManager.Instance.SaveCourses();
        }

        private void LoadFile(object sender, ExecutedRoutedEventArgs e)
        {
            LoadFileWindows loadFileWindows = new LoadFileWindows();
            loadFileWindows.ShowDialog();
        }
    }
}
