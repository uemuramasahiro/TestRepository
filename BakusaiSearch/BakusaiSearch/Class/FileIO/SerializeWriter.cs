using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace BakusaiSearch.Class
{
    public static class SerializeWriter<T> where T : class
    {
        public static void Write(string fileName, T items)
        {
            var serializer = new XmlSerializer(typeof(T));
            var sw = new StreamWriter(fileName, false, System.Text.Encoding.GetEncoding("shift_jis"));
            serializer.Serialize(sw, items);
            sw.Close();
        }
    }
}
