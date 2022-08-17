using LitJson;
using System;
using System.IO;
using System.Reflection;
using System.Windows;

namespace JsonTool
{
    internal class JsonMgr
    {
        /// <summary>
        /// 加载json数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        public static T LoadData<T>(string path) where T : new()
        {
            try
            {
                if (!File.Exists(path + ".json"))
                    return new T();

                string jsonStr = File.ReadAllText(path + ".json");
                T data = JsonMapper.ToObject<T>(jsonStr);
                return data;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

                return default(T);
            }


            
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="data"></param>
        /// <param name="path"></param>
        public static void Save(object data, string path)
        {
            string jsonStr = JsonMapper.ToJson(data);

            File.WriteAllText(path + ".json", jsonStr);
        }
    }
}
