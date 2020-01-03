namespace BakusaiSearch
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.Bt_Search = new System.Windows.Forms.Button();
            this.txt_SearchString1 = new System.Windows.Forms.TextBox();
            this.Lb_URL = new System.Windows.Forms.Label();
            this.Lb_SearchString = new System.Windows.Forms.Label();
            this.Lb_TitleLabel = new System.Windows.Forms.Label();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.Lb_SearchResult = new System.Windows.Forms.Label();
            this.txt_SearchString2 = new System.Windows.Forms.TextBox();
            this.txt_SearchString3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Page = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bt_Clear1 = new System.Windows.Forms.Button();
            this.txt_SearchString4 = new System.Windows.Forms.TextBox();
            this.txt_SearchString5 = new System.Windows.Forms.TextBox();
            this.Bt_Clear2 = new System.Windows.Forms.Button();
            this.txt_SearchString6 = new System.Windows.Forms.TextBox();
            this.txt_SearchString7 = new System.Windows.Forms.TextBox();
            this.txt_SearchString8 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_URL
            // 
            this.txt_URL.Location = new System.Drawing.Point(96, 12);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(291, 19);
            this.txt_URL.TabIndex = 1;
            // 
            // Bt_Search
            // 
            this.Bt_Search.Location = new System.Drawing.Point(368, 98);
            this.Bt_Search.Name = "Bt_Search";
            this.Bt_Search.Size = new System.Drawing.Size(64, 23);
            this.Bt_Search.TabIndex = 13;
            this.Bt_Search.Text = "検索";
            this.Bt_Search.UseVisualStyleBackColor = true;
            this.Bt_Search.Click += new System.EventHandler(this.Bt_Search_Click);
            // 
            // txt_SearchString1
            // 
            this.txt_SearchString1.Location = new System.Drawing.Point(96, 46);
            this.txt_SearchString1.Name = "txt_SearchString1";
            this.txt_SearchString1.Size = new System.Drawing.Size(108, 19);
            this.txt_SearchString1.TabIndex = 4;
            // 
            // Lb_URL
            // 
            this.Lb_URL.AutoSize = true;
            this.Lb_URL.Location = new System.Drawing.Point(35, 15);
            this.Lb_URL.Name = "Lb_URL";
            this.Lb_URL.Size = new System.Drawing.Size(27, 12);
            this.Lb_URL.TabIndex = 0;
            this.Lb_URL.Text = "URL";
            // 
            // Lb_SearchString
            // 
            this.Lb_SearchString.AutoSize = true;
            this.Lb_SearchString.Location = new System.Drawing.Point(35, 49);
            this.Lb_SearchString.Name = "Lb_SearchString";
            this.Lb_SearchString.Size = new System.Drawing.Size(53, 12);
            this.Lb_SearchString.TabIndex = 3;
            this.Lb_SearchString.Text = "検索文字";
            // 
            // Lb_TitleLabel
            // 
            this.Lb_TitleLabel.AutoSize = true;
            this.Lb_TitleLabel.Location = new System.Drawing.Point(35, 130);
            this.Lb_TitleLabel.Name = "Lb_TitleLabel";
            this.Lb_TitleLabel.Size = new System.Drawing.Size(40, 12);
            this.Lb_TitleLabel.TabIndex = 14;
            this.Lb_TitleLabel.Text = "タイトル";
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Location = new System.Drawing.Point(96, 133);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(0, 12);
            this.Lb_Title.TabIndex = 9;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(96, 127);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.ReadOnly = true;
            this.txt_Title.Size = new System.Drawing.Size(222, 19);
            this.txt_Title.TabIndex = 15;
            this.txt_Title.TabStop = false;
            // 
            // Lb_SearchResult
            // 
            this.Lb_SearchResult.AutoSize = true;
            this.Lb_SearchResult.Location = new System.Drawing.Point(324, 130);
            this.Lb_SearchResult.Name = "Lb_SearchResult";
            this.Lb_SearchResult.Size = new System.Drawing.Size(63, 12);
            this.Lb_SearchResult.TabIndex = 16;
            this.Lb_SearchResult.Text = "検索結果 : ";
            // 
            // txt_SearchString2
            // 
            this.txt_SearchString2.Location = new System.Drawing.Point(210, 45);
            this.txt_SearchString2.Name = "txt_SearchString2";
            this.txt_SearchString2.Size = new System.Drawing.Size(108, 19);
            this.txt_SearchString2.TabIndex = 5;
            // 
            // txt_SearchString3
            // 
            this.txt_SearchString3.Location = new System.Drawing.Point(324, 45);
            this.txt_SearchString3.Name = "txt_SearchString3";
            this.txt_SearchString3.Size = new System.Drawing.Size(108, 19);
            this.txt_SearchString3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Page,
            this.SearchList});
            this.dataGridView1.Location = new System.Drawing.Point(37, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1253, 536);
            this.dataGridView1.TabIndex = 17;
            // 
            // Page
            // 
            this.Page.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Page.DataPropertyName = "ページ";
            this.Page.HeaderText = "ページ";
            this.Page.Name = "Page";
            this.Page.Width = 60;
            // 
            // SearchList
            // 
            this.SearchList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SearchList.DataPropertyName = "検索結果";
            this.SearchList.HeaderText = "検索結果";
            this.SearchList.Name = "SearchList";
            // 
            // Bt_Clear1
            // 
            this.Bt_Clear1.Location = new System.Drawing.Point(393, 10);
            this.Bt_Clear1.Name = "Bt_Clear1";
            this.Bt_Clear1.Size = new System.Drawing.Size(39, 23);
            this.Bt_Clear1.TabIndex = 2;
            this.Bt_Clear1.Text = "クリア";
            this.Bt_Clear1.UseVisualStyleBackColor = true;
            this.Bt_Clear1.Click += new System.EventHandler(this.Bt_Clear1_Click);
            // 
            // txt_SearchString4
            // 
            this.txt_SearchString4.Location = new System.Drawing.Point(96, 71);
            this.txt_SearchString4.Name = "txt_SearchString4";
            this.txt_SearchString4.Size = new System.Drawing.Size(108, 19);
            this.txt_SearchString4.TabIndex = 7;
            // 
            // txt_SearchString5
            // 
            this.txt_SearchString5.Location = new System.Drawing.Point(210, 72);
            this.txt_SearchString5.Name = "txt_SearchString5";
            this.txt_SearchString5.Size = new System.Drawing.Size(108, 19);
            this.txt_SearchString5.TabIndex = 8;
            // 
            // Bt_Clear2
            // 
            this.Bt_Clear2.Location = new System.Drawing.Point(326, 97);
            this.Bt_Clear2.Name = "Bt_Clear2";
            this.Bt_Clear2.Size = new System.Drawing.Size(39, 23);
            this.Bt_Clear2.TabIndex = 12;
            this.Bt_Clear2.Text = "クリア";
            this.Bt_Clear2.UseVisualStyleBackColor = true;
            this.Bt_Clear2.Click += new System.EventHandler(this.Bt_Clear2_Click);
            // 
            // txt_SearchString6
            // 
            this.txt_SearchString6.Location = new System.Drawing.Point(324, 72);
            this.txt_SearchString6.Name = "txt_SearchString6";
            this.txt_SearchString6.Size = new System.Drawing.Size(108, 19);
            this.txt_SearchString6.TabIndex = 9;
            // 
            // txt_SearchString7
            // 
            this.txt_SearchString7.Location = new System.Drawing.Point(96, 96);
            this.txt_SearchString7.Name = "txt_SearchString7";
            this.txt_SearchString7.Size = new System.Drawing.Size(108, 19);
            this.txt_SearchString7.TabIndex = 10;
            // 
            // txt_SearchString8
            // 
            this.txt_SearchString8.Location = new System.Drawing.Point(210, 97);
            this.txt_SearchString8.Name = "txt_SearchString8";
            this.txt_SearchString8.Size = new System.Drawing.Size(108, 19);
            this.txt_SearchString8.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 713);
            this.Controls.Add(this.txt_SearchString8);
            this.Controls.Add(this.txt_SearchString7);
            this.Controls.Add(this.txt_SearchString6);
            this.Controls.Add(this.Bt_Clear2);
            this.Controls.Add(this.txt_SearchString5);
            this.Controls.Add(this.txt_SearchString4);
            this.Controls.Add(this.Bt_Clear1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_SearchString3);
            this.Controls.Add(this.txt_SearchString2);
            this.Controls.Add(this.Lb_SearchResult);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.Lb_Title);
            this.Controls.Add(this.Lb_TitleLabel);
            this.Controls.Add(this.Lb_SearchString);
            this.Controls.Add(this.Lb_URL);
            this.Controls.Add(this.txt_SearchString1);
            this.Controls.Add(this.Bt_Search);
            this.Controls.Add(this.txt_URL);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.Button Bt_Search;
        private System.Windows.Forms.TextBox txt_SearchString1;
        private System.Windows.Forms.Label Lb_URL;
        private System.Windows.Forms.Label Lb_SearchString;
        private System.Windows.Forms.Label Lb_TitleLabel;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label Lb_SearchResult;
        private System.Windows.Forms.TextBox txt_SearchString2;
        private System.Windows.Forms.TextBox txt_SearchString3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Page;
        private System.Windows.Forms.DataGridViewTextBoxColumn SearchList;
        private System.Windows.Forms.Button Bt_Clear1;
        private System.Windows.Forms.TextBox txt_SearchString4;
        private System.Windows.Forms.TextBox txt_SearchString5;
        private System.Windows.Forms.Button Bt_Clear2;
        private System.Windows.Forms.TextBox txt_SearchString6;
        private System.Windows.Forms.TextBox txt_SearchString7;
        private System.Windows.Forms.TextBox txt_SearchString8;
    }
}

