using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakusaiSearch.Class
{
    public sealed class Search
    {

        public Search()
        {

        }

        /// <summary>検索ページのタイトルを設定する</summary>
        /// <param name="htmlDocument"></param>
        public string GetTitleFromHtml(HtmlDocument htmlDocument)
        {
            string title = string.Empty;
            HtmlElementCollection titleTagCollection = htmlDocument.GetElementsByTagName(Define.TAG_TITLE);
            foreach (HtmlElement element in titleTagCollection)
            {
                int startIndex = element.InnerText.IndexOf("-");
                if (startIndex < 0) continue;
                title =  element.InnerText.Remove(startIndex);
                break;
            }

            return title;
        }

        /// <summary>検索文字を含む文字列のリストを設定する</summary>
        /// <param name="htmlDocument"></param>
        public List<SearchResult> GetSearchResult(HtmlDocument htmlDocument, List<string> seachStrList, int pageNo, string url)
        {
            HtmlElementCollection divTagCollection = htmlDocument.GetElementsByTagName(Define.TAG_DIV);
            var searchResultList = new List<SearchResult>();
            foreach (HtmlElement element in divTagCollection)
            {
                string str = element.GetAttribute(Define.ATTRIBUTE_NAME).ToString();
                if (str != Define.TAG_RESBODY) continue;
                if (!ContainSearchString(element.InnerText, seachStrList)) continue;
                searchResultList.Add(new SearchResult(pageNo, element.InnerText, url));
            }

            return searchResultList;
        }

        /// <summary>検索文字が含まれているかを判定</summary>
        /// <param name="content"></param>
        /// <returns></returns>
        private bool ContainSearchString(string content, List<string> seachStrList)
        {
            foreach (string searchStr in seachStrList)
            {
                string hiraganaSeachStr = Japanese.ToHiraganaFromKatakana(searchStr);
                string katakanaSeachStr = Japanese.ToKatakanaFromHiragana(searchStr);
                if (content.IndexOf(hiraganaSeachStr) >= 0 ||
                    content.IndexOf(katakanaSeachStr) >= 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
