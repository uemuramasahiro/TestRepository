using System;
using System.Linq;
using System.Windows.Forms;
using BakusaiSearch.Class;

namespace BakusaiSearch.WinForm
{
    public partial class FavoriteAddForm : Form
    {
        private FavoriteList _favoriteList = new FavoriteList();
        private PrefectureInfoManagement _prefectureInfoMng = new PrefectureInfoManagement();

        public FavoriteAddForm()
        {
            InitializeComponent();

            btn_OK.Text = "追加";

            Initialize();
        }

        private void Initialize()
        {
            SetComboBox();
        }

        private void SetComboBox()
        {
            cmb_Prefecture.DataSource = new BindingSource(_prefectureInfoMng.GetPrefectureList, null);
            cmb_Prefecture.Enabled = true;
            cmb_Prefecture.SelectedIndex = 0;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if(txt_Store.Text == string.Empty)
            {
                MessageBox.Show("空");
                return;
            }

            if (_favoriteList.GetStoreList().Any(x => x == txt_Store.Text))
            {
                MessageBox.Show("同名存在");
                return;
            }

            var item = new FavoriteItem(txt_Store.Text, cmb_Prefecture.SelectedText);
            _favoriteList.AddWrite(item);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
