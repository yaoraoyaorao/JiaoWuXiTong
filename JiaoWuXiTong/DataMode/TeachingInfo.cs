using System.Collections.Generic;

namespace JiaoWuXiTong.DataMode
{
    /// <summary>
    /// 教学信息
    /// </summary>
    public class TeachingInfo
    {
        //教师
        public Teacher teacher { get; set; }
        //课程列表
        public List<Course> courses { get; set; }   
    }
}
