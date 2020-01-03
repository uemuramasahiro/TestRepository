
namespace BakusaiSearch
{
    public class SearchResult
    {
        public SearchResult(int pageNo, string content, string url)
        {
            PageNo = pageNo;
            Content = content;
            Url = url;
        }

        public int PageNo { get; set; }

        public string Content { get; set; }

        public string Url { get; set; }
    }
}
