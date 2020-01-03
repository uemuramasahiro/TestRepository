using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BakusaiSearch.Class;

namespace BakusaiSearch.WinForm
{
    public partial class FavoriteDeleteForm : Form
    {
        private FavoriteList _favoriteList = new FavoriteList();

        public FavoriteDeleteForm()
        {
            InitializeComponent();

            SetComboBox();
        }

        private void SetComboBox()
        {
            cmb_DeleteItem.DataSource = new BindingSource(_favoriteList.GetStoreList(), null);
            cmb_DeleteItem.Enabled = true;
            cmb_DeleteItem.SelectedIndex = 0;
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            var storeName = (string)cmb_DeleteItem.SelectedItem;
            _favoriteList.RemoveWrite(storeName);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
