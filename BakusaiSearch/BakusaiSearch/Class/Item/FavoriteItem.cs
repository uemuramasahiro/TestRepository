using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakusaiSearch.Class
{
    public class FavoriteItem
    {
        public FavoriteItem()
        {

        }

        public FavoriteItem(string storeName, string prefecture)
        {
            StoreName = storeName;
            Prefecture = prefecture;
        }

        public string StoreName { get; set; }

        public string Prefecture { get; set; }
    }
}
