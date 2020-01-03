using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakusaiSearch.Class
{
    public sealed class FavoriteList
    {
        private List<FavoriteItem> _favoriteItems = new List<FavoriteItem>();

        public FavoriteList()
        {
            Read();
        }

        public List<FavoriteItem> FavoriteItems => _favoriteItems;

        public string[] GetStoreList() => _favoriteItems.Select(x => x.StoreName).ToArray();

        public string GetPrefecture(string storeName) => _favoriteItems.First(x => x.StoreName == storeName).Prefecture;

        public bool HasItem() => _favoriteItems.Count != 0;

        public void Read()
        {
            CreateFileIfNotExsist();
            _favoriteItems = SerializeReader<List<FavoriteItem>>.Read(Define.FAVORITE_FILE_PATH);
        }

        public void Write()
        {
            CreateFileIfNotExsist();
            SerializeWriter<List<FavoriteItem>>.Write(Define.FAVORITE_FILE_PATH, _favoriteItems);
        }

        public void AddWrite(FavoriteItem item)
        {
            _favoriteItems.Add(item);
            Write();
        }

        public void RemoveWrite(string storeName)
        {
            var item = _favoriteItems.First(x => x.StoreName == storeName);
            _favoriteItems.Remove(item);
            Write();
        }

        private void CreateFileIfNotExsist()
        {
            if (!File.Exists(Define.FAVORITE_FILE_PATH))
            {
                Directory.CreateDirectory(Define.FAVORITE_FOLDER_PATH);
                var fs = File.Create(Define.FAVORITE_FILE_PATH);
                fs.Close();
                Write();
            }
        }
    }
}
