using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakusaiSearch
{
    class SaveFile
    {
        private string m_FolderPath;

        private string m_FilePath;

        private string m_FileName;

        private string m_Title;

        private string m_SearchStr;

        private Dictionary<int, SearchResult> m_targetStrDictionary;

        public SaveFile()
        {
            m_targetStrDictionary = new Dictionary<int, SearchResult>();
            init();     
        }

        private void init()
        {
            m_FolderPath = string.Empty;

            m_FilePath = string.Empty;

            m_FileName = string.Empty;

            m_Title = string.Empty;

            m_SearchStr = string.Empty;

            m_targetStrDictionary.Clear();
        }

        public bool Save(Dictionary<int, SearchResult> inTargetStrDictionary , string inTitle , string inSearchStr )
        {
            m_targetStrDictionary = inTargetStrDictionary;
            m_Title = inTitle;
            m_SearchStr = inSearchStr;

            // フォルダパスを取得
            // ReadFolderPathFromXML();
            m_FolderPath = "D:\\Desktop\\test";

            // ファイル作成
            m_FileName = inTitle + "_" + inSearchStr;
            m_FilePath = m_FolderPath + "\\" + m_FileName + ".txt";

            // 書き込み
            bool ret = Write();

            return true;
        }

        private void ReadFolderPathFromXML()
        {

        }

        private bool Write()
        {
            // ファイル書き込み処理
            System.IO.StreamWriter sw = null;
            try
            {
                sw = new System.IO.StreamWriter(m_FilePath, true, System.Text.Encoding.GetEncoding("Shift-JIS"));

                // タイトルと検索文字列出力
                sw.WriteLine("タイトル : " + m_Title);
                sw.WriteLine("検索文字 : " + m_SearchStr);

                // 出力文字列作成
                foreach (KeyValuePair<int, SearchResult> info in m_targetStrDictionary)
                {
                    string page = info.Value.PageNo.ToString();
                    string targetStr = info.Value.Content;
                    string URL = info.Value.Url;

                    string Str = page + "   ,   " + targetStr + "   ,   " + URL;

                    // 書き込む
                    sw.WriteLine(Str);
                }
            }
            catch { return false;  }
            finally
            {
                if (sw != null) sw.Close();
            }

            return true;
        }

    }
}
