using JiaoWuXiTong.DataMode;
using JsonTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiaoWuXiTong.Core
{
    /// <summary>
    /// 数据管理类
    /// </summary>
    public class DataManager
    {
        private static DataManager instance;

        public static DataManager Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DataManager();
                }
                return instance;
            }
        }

        public Config config;
        
        public List<Course> courses;
        public List<Teacher> teachers;

        private DataManager()
        {
            courses = JsonMgr.LoadData<List<Course>>("Data/Courses");
            teachers = JsonMgr.LoadData<List<Teacher>>("Data/Teachers");
            config = JsonMgr.LoadData<Config>("Data/Config");
        }

        public void SaveCourses()
        {
            JsonMgr.Save(courses, "Data/Courses");
        }

        public void SaveTeacher()
        {
            JsonMgr.Save(teachers, "Data/Teachers");
        }

        public void SaveConfig()
        {
            JsonMgr.Save(config, "Data/Config");
        }
    }
}
