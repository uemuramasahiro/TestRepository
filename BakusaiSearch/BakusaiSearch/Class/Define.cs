using System.Collections.Generic;

namespace BakusaiSearch
{
    class Define
    {
        public static string FAVORITE_FILE_PATH = @"D:\Desktop\BakusaiSearch\Favorite\FavoriteList.xml";

        public static string FAVORITE_FOLDER_PATH = @"D:\Desktop\BakusaiSearch\Favorite";

        public static string PRIFECTURE_FILE_PATH = @"D:\Desktop\BakusaiSearch\Prefecture\PrefectureInfo.xml";

        public static string PRIFECTURE_FOLDER_PATH = @"D:\Desktop\BakusaiSearch\Prefecture";

        public static string SEARCH_RESULT = "検索結果";

        public static string PAGR = "ページ";

        public static string NEXT_PAGR = "次のページ";

        public static string BAKUSAI_URL = "http://bakusai.com/";
        public static string BAKUSAI_URL_SEARCH_PAGE_HYOGO = "http://bakusai.com/sch_in_thr_bbs0/acode=7/ctgid=103/bid=436/tp=2/";
        public static string BAKUSAI_SEARCH_PAGE_KEY = "http://bakusai.com/sch_in_thr_bbs0/";
        public static string BAKUSAI_BBS_PAGE_KEY = "http://bakusai.com/thr_res/";

        public static string DATASORCE_TABLE_NAME = "SearchList";

        public static string TAG_TITLE = "title";

        public static string TAG_DIV = "div";

        public static string TAG_RESBODY = "resbody";

        public static string TAG_A = "a";

        public static string TAG_HREF = "href";

        public static string ATTRIBUTE_NAME = "className";

        public static string COMBOBOX_ITEM_OOSAKA = "大阪";
        public static string LINKLABEL_OOSAKA = "大阪風俗・お店";
        public static string LINK_URL_OOSAKA = "http://bakusai.com/sch_in_thr_bbs0/acode=7/ctgid=103/bid=410/";

        public static string COMBOBOX_ITEM_HYOGO = "兵庫";
        public static string LINKLABEL_HYOGO = "兵庫風俗・お店";
        public static string LINK_URL_HYOGO = "http://bakusai.com/sch_in_thr_bbs0/acode=7/ctgid=103/bid=436/tp=1/";

        public static string COMBOBOX_ITEM_KYOTO = "京都";
        public static string LINKLABEL_KYOTO = "京都風俗・お店";
        public static string LINK_URL_KYOTO = "http://bakusai.com/sch_in_thr_bbs0/acode=7/ctgid=103/bid=418/tp=1/";

        public static string COMBOBOX_ITEM_TOKYOU = "東京";
        public static string LINKLABEL_TOKYOU = "東京風俗・お店";
        public static string LINKL_URL_TOKYOU = "http://bakusai.com/sch_in_thr_bbs0/acode=3/ctgid=103/bid=412/";

        public static string COMBOBOX_ITEM_SIGA = "滋賀";
        public static string LINKLABEL_SIGA = "滋賀風俗・お店";
        public static string LINK_URL_SIGA = "http://bakusai.com/sch_in_thr_bbs0/acode=7/ctgid=103/bid=239/tp=1/";

        public static string ERR_TEXTBOX_URL_EMPTY = "URLを入力してください。";
        public static string ERR_TEXTBOX_URL_SEARCHSTRING = "検索文字を入力してください。";

        public static string ERR_BAKUSAI_URL = "爆サイURLではありません。";
        public static string ERR_BAKUSAI_BBS = "爆サイ掲示板URLではありません。";

        public static int TEXTBOX_COUNT = 8;

        // パス
        public static string LIST_FOLDER_PATH = @"D:\Desktop\test";
        public static string HP_LIST_FILE_PATH = @"D:\Desktop\test\HPList.xml";
        //public static string FAVORITE_LIST_FILE_PATH = @"D:\Desktop\test\FavoriteList.xml";

        // XMLタグ
        public static string XML_TAG_HP_LIST = "HomePageList";
        public static string XML_TAG_FAVORITE_LIST = "FavoriteList";

        public enum ListKind : int
        {
            HP = 0,
            Favorite,
        }

        public static readonly List<string> LocationList = new List<string> {
            Define.COMBOBOX_ITEM_OOSAKA,
            Define.COMBOBOX_ITEM_HYOGO,
            Define.COMBOBOX_ITEM_KYOTO,
            Define.COMBOBOX_ITEM_TOKYOU,
            Define.COMBOBOX_ITEM_SIGA
        };

        public static readonly Dictionary<string, string> LocationUrlList = new Dictionary<string, string>
        {
            {Define.COMBOBOX_ITEM_OOSAKA, Define.LINK_URL_OOSAKA},
            {Define.COMBOBOX_ITEM_HYOGO, Define.LINK_URL_HYOGO},
            {Define.COMBOBOX_ITEM_KYOTO, Define.LINK_URL_KYOTO},
            {Define.COMBOBOX_ITEM_TOKYOU, Define.LINKL_URL_TOKYOU},
            {Define.COMBOBOX_ITEM_SIGA, Define.LINK_URL_SIGA}
        };

        public static readonly Dictionary<string, string> LinkLavelDictionary = new Dictionary<string, string>
        {
            {Define.COMBOBOX_ITEM_OOSAKA, Define.LINKLABEL_OOSAKA},
            {Define.COMBOBOX_ITEM_HYOGO, Define.LINKLABEL_HYOGO},
            {Define.COMBOBOX_ITEM_KYOTO, Define.LINKLABEL_KYOTO},
            {Define.COMBOBOX_ITEM_TOKYOU, Define.LINKLABEL_TOKYOU},
            {Define.COMBOBOX_ITEM_SIGA, Define.LINKLABEL_SIGA}
        };
    }
}
