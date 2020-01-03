using System.IO;
using System.Xml.Serialization;

namespace BakusaiSearch.Class
{
    public static class SerializeReader<T> where T : class
    {
        public static T Read(string fileName)
        {
            var serializer = new XmlSerializer(typeof(T));
            var sr = new StreamReader(fileName, System.Text.Encoding.GetEncoding("shift_jis"));
            var obj = (T)serializer.Deserialize(sr);
            sr.Close();

            return obj;
        }
    }
}
