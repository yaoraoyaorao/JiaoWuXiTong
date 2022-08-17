using System.Collections.Generic;

namespace JiaoWuXiTong.DataMode
{
    /// <summary>
    /// 排课信息
    /// </summary>
    public class ScheduleInfo
    {
        //课程
        public Course course { get; set; }
        //上课教师
        public Teacher teacher { get; set; }
        //上课时间
        public Time time { get; set; }
        //上课地点
        public Place place { get; set; }
        //学生信息
        public ClassInfo classInfo { get; set; }
        //备注
        public string remarks { get; set; }

    }
}
