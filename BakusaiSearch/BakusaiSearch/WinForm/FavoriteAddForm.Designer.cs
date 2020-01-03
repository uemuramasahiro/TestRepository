namespace BakusaiSearch.WinForm
{
    partial class FavoriteAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_StoreName = new System.Windows.Forms.Label();
            this.txt_Store = new System.Windows.Forms.TextBox();
            this.lbl_Prefecture = new System.Windows.Forms.Label();
            this.cmb_Prefecture = new System.Windows.Forms.ComboBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_StoreName
            // 
            this.lbl_StoreName.AutoSize = true;
            this.lbl_StoreName.Location = new System.Drawing.Point(13, 13);
            this.lbl_StoreName.Name = "lbl_StoreName";
            this.lbl_StoreName.Size = new System.Drawing.Size(29, 12);
            this.lbl_StoreName.TabIndex = 0;
            this.lbl_StoreName.Text = "店名";
            // 
            // txt_Store
            // 
            this.txt_Store.Location = new System.Drawing.Point(15, 29);
            this.txt_Store.Name = "txt_Store";
            this.txt_Store.Size = new System.Drawing.Size(193, 19);
            this.txt_Store.TabIndex = 1;
            // 
            // lbl_Prefecture
            // 
            this.lbl_Prefecture.AutoSize = true;
            this.lbl_Prefecture.Location = new System.Drawing.Point(15, 64);
            this.lbl_Prefecture.Name = "lbl_Prefecture";
            this.lbl_Prefecture.Size = new System.Drawing.Size(29, 12);
            this.lbl_Prefecture.TabIndex = 2;
            this.lbl_Prefecture.Text = "場所";
            // 
            // cmb_Prefecture
            // 
            this.cmb_Prefecture.FormattingEnabled = true;
            this.cmb_Prefecture.Location = new System.Drawing.Point(17, 79);
            this.cmb_Prefecture.Name = "cmb_Prefecture";
            this.cmb_Prefecture.Size = new System.Drawing.Size(191, 20);
            this.cmb_Prefecture.TabIndex = 3;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(17, 114);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "button1";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(133, 114);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "キャンセル";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // FavoriteAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 154);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.cmb_Prefecture);
            this.Controls.Add(this.lbl_Prefecture);
            this.Controls.Add(this.txt_Store);
            this.Controls.Add(this.lbl_StoreName);
            this.Name = "FavoriteAddForm";
            this.Text = "FavoriteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_StoreName;
        private System.Windows.Forms.TextBox txt_Store;
        private System.Windows.Forms.Label lbl_Prefecture;
        private System.Windows.Forms.ComboBox cmb_Prefecture;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
    }
}