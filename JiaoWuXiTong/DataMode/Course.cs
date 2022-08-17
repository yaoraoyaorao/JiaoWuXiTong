namespace JiaoWuXiTong.DataMode
{
    /// <summary>
    /// 课程
    /// </summary>
    public class Course
    {
        //课程ID
        public int ID { get; set; }
        //课程名
        public string Name { get; set; }

        public Course()
        {

        }
        public Course(int i, string name)
        {
            ID = i;
            Name = name;
        }
    }
}
