using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using mshtml;
using SHDocVw;
using BakusaiSearch.Class;
using BakusaiSearch.WinForm;

namespace BakusaiSearch
{

    public partial class MainForm : Form
    {
        
        #region メンバ変数

        private string _url;
        private string _favoriteUrl;
        private DataTable _dataTable = Utility.DataGridViewBindTable;
        private string _linkLabel1;

        private FavoriteList _favoriteList = new FavoriteList();
        private PrefectureInfoManagement _prefectureInfoMng = new PrefectureInfoManagement();

        private BrowserOperator _browserOperator = new BrowserOperator();

        #endregion

        /// <summary>コンストラクタ</summary>
        public MainForm()
        {
            InitializeComponent();           
        }

        /// <summary>初期化</summary>
        private void Init()
        {
            Lb_SearchResult.Text = Define.SEARCH_RESULT + " : ";
            _url = Define.BAKUSAI_URL;
            _favoriteUrl = string.Empty;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            _linkLabel1 = string.Empty;

            ResisterEvent();

            
        }

        private void InitSearch()
        {
            _url = Define.BAKUSAI_URL;
            Lb_SearchResult.Text = Define.SEARCH_RESULT + " : ";
            _dataTable.Clear();
        }

        private void ResisterEvent()
        {
            _browserOperator.SearchCompleted += BrowserOperator_SearchCompleted;
            _browserOperator.SearchOnlyPageCompleted += BrowserOperator_SearchOnlyPageCompleted;
            _browserOperator.ErrorOccurred += BrowserOperator_ErrorOccurred;
        }

        private void RemoveEvent()
        {
            _browserOperator.SearchCompleted -= BrowserOperator_SearchCompleted;
            _browserOperator.SearchOnlyPageCompleted -= BrowserOperator_SearchOnlyPageCompleted;
            _browserOperator.ErrorOccurred -= BrowserOperator_ErrorOccurred;
        }

        /// <summary>DataGridViewに表示する</summary>
        private void DisplayDataGridView()
        {
            _dataTable.Clear();

            foreach (var searchResult in _browserOperator.SearchResultList)
            {
                var row = _dataTable.NewRow();
                row[Define.PAGR] = searchResult.PageNo.ToString();
                row[Define.SEARCH_RESULT] = searchResult.Content;
                _dataTable.Rows.Add(row);
            }
            dataGridView1.DataSource = _dataTable;
        }


        /// <summary>検索ボタン押下時の処理</summary>
        private void Bt_Search_Click(object sender, EventArgs e)
        {
            if (!IsValidInput()) return;

            InitSearch();

            Lb_SearchResult.Text = Define.SEARCH_RESULT + " : " + "検索中";

            // 次ページのURLを設定
            _url = _url + txt_URL.Text.Replace(_url, "");

            // Webページアクセス
            _browserOperator.SearchStart(CreateSearchStrList(), _url);
        }

        /// <summary>入力が妥当か</summary>
        private bool IsValidInput()
        {
            // URLテキストボックス入力チェック
            if (txt_URL.Text == string.Empty)
            {
                MessageBox.Show(Define.ERR_TEXTBOX_URL_EMPTY, "", MessageBoxButtons.OK);
                return false;
            }

            // 検索文字テキストボックス入力チェック
            if (ErrCheck.IsEmptySearchStringTextBox(Controls))
            {
                MessageBox.Show(Define.ERR_TEXTBOX_URL_SEARCHSTRING, "", MessageBoxButtons.OK);
                return false;
            }

            string errMsg = string.Empty;
            // URLが爆サイ掲示板であるか確認
            if (!ErrCheck.IsValidUrl(txt_URL.Text, out errMsg))
            {
                MessageBox.Show(errMsg, "", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }


        /// <summary>検索文字のリストを作成する</summary>
        private List<string> CreateSearchStrList()
        {
            var list = new List<string>();

            for (int i = 1; i <= Define.TEXTBOX_COUNT; i++)
            {
                Control[] cs = Controls.Find("txt_SearchString" + i.ToString(), true);
                if (cs.Length <= 0) { continue; }
                TextBox textBox = cs[0] as TextBox;
                if (textBox.Text == string.Empty) { continue; }
                list.Add(textBox.Text);
            }

            return list;
        }


        /// <summary>フォームロード処理</summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                Init();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataMember = Define.DATASORCE_TABLE_NAME;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>URLテキストのクリアボタン押下時の処理</summary>
        private void Bt_Clear1_Click(object sender, EventArgs e)
        {
            txt_URL.Text = string.Empty;
        }

        /// <summary>検索テキストのクリアボタン押下時の処理</summary>
        private void Bt_Clear2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= Define.TEXTBOX_COUNT; i++)
            {
                Control[] cs = Controls.Find("txt_SearchString" + i.ToString(), true);
                if (cs.Length <= 0) continue;
                var textBox = cs[0] as TextBox;
                textBox.Text = string.Empty;
            }
        }

        private void BrowserOperator_ErrorOccurred(object sender, EventArgs e)
        {

        }

        private void BrowserOperator_SearchOnlyPageCompleted(object sender, EventArgs e)
        {
            dataGridView1.BeginInvoke(new Action(DisplayDataGridView));
        }

        private void BrowserOperator_SearchCompleted(object sender, EventArgs e)
        {
            dataGridView1.BeginInvoke(new Action(DisplayDataGridView));
            txt_Title.Text = _browserOperator.Title;
            Lb_SearchResult.Text = Define.SEARCH_RESULT + " : " + _browserOperator.SearchResultList.Count.ToString() + "件";

        }
    }
}
