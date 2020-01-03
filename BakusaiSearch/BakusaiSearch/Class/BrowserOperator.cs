using mshtml;
using SHDocVw;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace BakusaiSearch.Class
{
    public sealed class BrowserOperator
    {
        private System.Windows.Forms.WebBrowser _browser = new System.Windows.Forms.WebBrowser();
        private string _title;
        private string _url;
        private string _nextPageUrl;
        private int _pageNo;

        private List<string> _seachStrList;
        private List<SearchResult> _searchResultList = new List<SearchResult>();

        private Search _search = new Search();

        public event EventHandler SearchCompleted;
        public event EventHandler SearchOnlyPageCompleted;
        public event EventHandler ErrorOccurred;

        public BrowserOperator()
        {
            InitWebBrowser();
        }

        public string Title => _title;

        public List<SearchResult> SearchResultList => _searchResultList;

        public void SearchStart(List<string> seachStrList, string url)
        {
            Init();
            _seachStrList = seachStrList;
            _url = url;
            _browser.Navigate(_url);
        }

        /// <summary>初期化</summary>
        private void Init()
        {
            _searchResultList.Clear();
            _title = string.Empty;
            _url = Define.BAKUSAI_URL;
            _nextPageUrl = string.Empty;
            _pageNo = 1;
        }


        /// <summary>WEBブラウザインスタンス初期化</summary>
        private void InitWebBrowser()
        {
            _browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(browser_DocumentCompleted);
            _browser.ScriptErrorsSuppressed = true;
        }

        /// <summary>次ページのURLを取得する</summary>
        /// <param name="htmlDocument"></param>
        /// <returns></returns>
        private string GetNextPageURL(HtmlDocument htmlDocument)
        {
            string nextPageURL = string.Empty;

            HtmlElementCollection aTagCollection = htmlDocument.GetElementsByTagName(Define.TAG_A);

            foreach (HtmlElement element in aTagCollection)
            {
                if (element.InnerText == Define.NEXT_PAGR)
                {
                    nextPageURL = element.GetAttribute(Define.TAG_HREF).ToString();
                }
            }

            return nextPageURL;
        }

        /// <summary>Webページ読み込み完了時の処理</summary>
        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                // タイトル取得
                if (_title == string.Empty)
                {
                    _title = _search.GetTitleFromHtml(_browser.Document);
                    //SetTitleFromHtml(_browser.Document);
                }
                
                if (_browser.ReadyState == WebBrowserReadyState.Complete)
                {
                    // 検索文字を含む文字列を取得
                    _searchResultList.AddRange(_search.GetSearchResult(_browser.Document, _seachStrList, _pageNo, _url));
                    //SetSearchResult(_browser.Document);

                    // 次ページのURLを取得
                    _nextPageUrl = GetNextPageURL(_browser.Document);
                    if (_nextPageUrl == string.Empty)
                    {
                        SearchCompleted?.Invoke(this, EventArgs.Empty);
                        return;
                    }

                    _nextPageUrl = _url + _nextPageUrl;

                    _pageNo++;

                    // 次ページにアクセス               
                    _browser.Navigate(_nextPageUrl);

                    // 一ページ検索終了
                    SearchOnlyPageCompleted?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                //Init();
                // errorイベント
                MessageBox.Show("検索に失敗しました。\n" + ex.ToString());

            }
        }

        public void DisolayBbs(string Url, string storeName)
        {
            InternetExplorer IE = StartUpIE(Url);
            ClickIESearchButton(IE, storeName);
            IE.Visible = true;
        }

        /// <summary>
        /// IEで検索ボタンを押下する処理
        /// </summary>
        /// <param name="IE"></param>
        private void ClickIESearchButton(InternetExplorer IE, string storeName)
        {
            var doc = IE.Document as mshtml.IHTMLDocument3;

            // 検索テキストタグ取得
            IHTMLElement searchText = doc.getElementById("idWord");

            // 検索文字列入力
            searchText.innerText = storeName;

            // 検索ボタン押下
            doc.getElementById("idWord");
            IHTMLElementCollection elementCollection = doc.getElementsByTagName("input");
            foreach (IHTMLElement element in elementCollection)
            {
                string outerHtml = element.outerHTML;
                if (outerHtml.IndexOf("検索") > 0)
                {
                    element.click();
                }
            }
        }

        /// <summary>
        /// IEを起動する
        /// </summary>
        /// <returns></returns>
        private InternetExplorer StartUpIE(string inURL)
        {
            var IE = new InternetExplorer();
            IE.Top = 0;
            IE.Left = 0;
            IE.Width = 1400;
            IE.Height = 1000;

            object URL = inURL;
            IE.Navigate2(ref URL);
            IEWait(IE); //ページ内の要素を書き換えるためには、ページが表示されるまで待つ必要あり

            return IE;
        }


        /// <summary>
        /// IE起動を待つ
        /// </summary>
        /// <param name="ie"></param>
        /// <param name="millisecond"></param>
        private void IEWait(SHDocVw.InternetExplorer ie, int millisecond = 2000)
        {
            while (ie.Busy == true || ie.ReadyState != SHDocVw.tagREADYSTATE.READYSTATE_COMPLETE)
            {
                Thread.Sleep(100);
            }
            Thread.Sleep(millisecond);

        }
    }
}
