using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakusaiSearch.Class.Item;

namespace BakusaiSearch.Class
{
    public sealed class PrefectureInfoManagement
    {
        private List<PrefectureInfo> _prefectureInfoList = new List<PrefectureInfo>();

        public PrefectureInfoManagement()
        {
            Read();
        }

        public List<PrefectureInfo> PrefectureInfoList => _prefectureInfoList;

        public void Read()
        {
            CreateFileIfNotExsist();
            _prefectureInfoList = SerializeReader<List<PrefectureInfo>>.Read(Define.PRIFECTURE_FILE_PATH);
        }

        public void Write()
        {
            CreateFileIfNotExsist();
            SerializeWriter<List<PrefectureInfo>>.Write(Define.PRIFECTURE_FILE_PATH, _prefectureInfoList);
        }

        public string[] GetPrefectureList => PrefectureInfoList.Select(x => x.Prefecture).ToArray();

        private void CreateFileIfNotExsist()
        {
            if (!File.Exists(Define.PRIFECTURE_FILE_PATH))
            {
                Directory.CreateDirectory(Define.PRIFECTURE_FOLDER_PATH);
                var fs = File.Create(Define.PRIFECTURE_FILE_PATH);
                fs.Close();
                Write();
            }
        }
    }
}
