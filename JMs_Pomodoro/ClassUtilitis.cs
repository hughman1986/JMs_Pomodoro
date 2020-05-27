using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMs_Pomodoro
{
    class ClassUtilitis
    {
        public class JSON_File_Operator
        {

            string FilePath;
            public JSON_File_Operator(string filepath)
            {
                FilePath = filepath;
            }

            /// <summary>
            /// 將物件寫入成 JSON 檔案 
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="ClassObject"></param>
            public void Serialize_JSON_to_a_file<T>(T ClassObject)
            {
                var DirectoryName = Path.GetDirectoryName(FilePath);
                if (!Directory.Exists(DirectoryName))
                    Directory.CreateDirectory(DirectoryName);
                string json = JsonConvert.SerializeObject(ClassObject, Formatting.Indented);
                File.WriteAllText(FilePath, json);
            }

            /// <summary>
            /// 將物件從 .json檔載入, 
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="ClassObject"></param>
            /// <returns></returns>
            public object Deserialize_JSON_from_a_file<T>(T ClassObject)
            {
                 if (!File.Exists(FilePath))
                    return ClassObject;

                // deserialize JSON directly from a file
                using (StreamReader file = File.OpenText(FilePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    var ReadData = serializer.Deserialize(file, typeof(T));
                    return ReadData;
                }
            }

        }

    }
}
