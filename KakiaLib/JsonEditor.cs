using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KakiaLib
{
    public class JsonEditor
    {
            public static void Serialize<T>(T data, string path)
            {
                try
                {
                    File.WriteAllText(path, JsonConvert.SerializeObject(data));
                }
                catch (Exception exception)
                {
                    throw new Exception("Андрюха, у нас \n" + exception + "\n возможно криминал, по коням");

                }
            }

            public static T Deserialize<T>(string path)
            {


                try
                {
                    T data = JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
                    return data;
                }
                catch (Exception exception)
                {
                    throw new Exception("Андрюха, у нас \n" + exception + "\n возможно криминал, по коням");

                }

            

        }
    }
}
