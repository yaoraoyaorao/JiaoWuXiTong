using System.ComponentModel;

namespace JiaoWuXiTong.DataMode
{
    /// <summary>
    /// 加载文件数据
    /// </summary>
    public class LoadFileData: INotifyPropertyChanged
    {
        private bool _state;
        private string _originalPath;
        private string _projectPath;
        public event PropertyChangedEventHandler PropertyChanged;   
        public int ID { get; set; }
        public string Name { get; set; }
        public bool State {
            get { return _state; }
            set 
            {
                _state = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("State"));
                }
            } 
        }
        public string OriginalPath
        {
            get { return _originalPath; }
            set
            {
                _originalPath = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("OriginalPath"));
                }
            }
        }

        public string ProjectPath
        {
            get { return _projectPath; }
            set
            {
                _projectPath = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("ProjectPath"));
                }
            }
        }

        public string Btn_Content
        {
            get
            {
                if (!State)
                {
                    return "导入";
                }
                return "重新导入";
            }
        }
        
        
        public LoadFileData()
        {

        }
        public LoadFileData(int id,string n,bool s)
        {
            ID = id;
            Name = n;
            State = s;
        }
    }
}
