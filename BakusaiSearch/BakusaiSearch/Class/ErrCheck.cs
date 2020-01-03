using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace BakusaiSearch
{
    public class ErrCheck
    {
        /// <summary>URLテキストボックスが空であるかを判定する</summary>
        /// <returns></returns>
        public static bool IsEmptyURLTextBox(string inTextBoxStr, out string outErrMsg)
        {
            outErrMsg = string.Empty;

            if (inTextBoxStr == string.Empty)
            {
                outErrMsg = Define.ERR_TEXTBOX_URL_EMPTY;
                return true;
            }
            return false;
        }

        /// <summary>検索文字テキストボックスが空であるかを判定する</summary>
        /// <returns></returns>
        public static bool IsEmptySearchStringTextBox(string inTextBoxStr)
        {
            if (inTextBoxStr == string.Empty)
            {
                return true;
            }
            return false;
        }

        /// <summary>検索文字テキストボックスが空であるかを判定する</summary>
        /// <param name="outErrMsg"></param>
        /// <returns></returns>
        public static bool IsEmptySearchStringTextBox(ControlCollection controls)
        {
            int emptyTextBoxCount = 0;
            for (int i = 1; i <= Define.TEXTBOX_COUNT; i++)
            {
                Control[] cs = controls.Find("txt_SearchString" + i.ToString(), true);
                if (cs.Length <= 0) { continue; }
                TextBox textBox = cs[0] as TextBox;
                if (ErrCheck.IsEmptySearchStringTextBox(textBox.Text))
                {
                    emptyTextBoxCount++;
                }
            }
            return emptyTextBoxCount == Define.TEXTBOX_COUNT;
        }


        /// <summary>URLが妥当かを判定する</summary>
        /// <param name="inInputUrl"></param>
        /// <returns></returns>
        public static bool IsValidUrl(string inInputUrl, out string outErrMsg)
        {
            outErrMsg = string.Empty;

            // 爆サイURLか
            if (inInputUrl.IndexOf(Define.BAKUSAI_URL) < 0)
            {
                outErrMsg = Define.ERR_BAKUSAI_URL;
                return false;
            }

            // 掲示板か
            if (inInputUrl.IndexOf(Define.BAKUSAI_BBS_PAGE_KEY) < 0)
            {
                outErrMsg = Define.ERR_BAKUSAI_BBS;
                return false;
            }

            return true;
        }
    }
}
