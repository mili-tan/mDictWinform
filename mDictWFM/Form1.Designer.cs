namespace mDictWFM
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAbout = new System.Windows.Forms.Label();
            this.btnSearch = new MaterialSkin.Controls.MaterialFlatButton();
            this.wordText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelWord = new System.Windows.Forms.Label();
            this.labelEp = new System.Windows.Forms.Label();
            this.backgroundWorkerDict = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // labelAbout
            // 
            this.labelAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAbout.AutoEllipsis = true;
            this.labelAbout.AutoSize = true;
            this.labelAbout.BackColor = System.Drawing.Color.Transparent;
            this.labelAbout.Font = new System.Drawing.Font("Noto Sans CJK SC Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAbout.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelAbout.Location = new System.Drawing.Point(88, 518);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(174, 22);
            this.labelAbout.TabIndex = 0;
            this.labelAbout.Text = "数据来源 : Bing / Youdao";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.AutoSize = true;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Depth = 0;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(281, 77);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Primary = false;
            this.btnSearch.Size = new System.Drawing.Size(56, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // wordText
            // 
            this.wordText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordText.Depth = 0;
            this.wordText.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.wordText.Hint = "输入你想要查询的单词";
            this.wordText.Location = new System.Drawing.Point(12, 77);
            this.wordText.MaxLength = 32767;
            this.wordText.MouseState = MaterialSkin.MouseState.HOVER;
            this.wordText.Name = "wordText";
            this.wordText.PasswordChar = '\0';
            this.wordText.SelectedText = "";
            this.wordText.SelectionLength = 0;
            this.wordText.SelectionStart = 0;
            this.wordText.Size = new System.Drawing.Size(262, 33);
            this.wordText.TabIndex = 2;
            this.wordText.TabStop = false;
            this.wordText.UseSystemPasswordChar = false;
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Noto Sans CJK SC Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelWord.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelWord.Location = new System.Drawing.Point(4, 122);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(166, 44);
            this.labelWord.TabIndex = 3;
            this.labelWord.Text = "labelWord";
            // 
            // labelEp
            // 
            this.labelEp.AutoSize = true;
            this.labelEp.Font = new System.Drawing.Font("Noto Sans CJK SC Regular", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelEp.Location = new System.Drawing.Point(7, 166);
            this.labelEp.Name = "labelEp";
            this.labelEp.Size = new System.Drawing.Size(79, 28);
            this.labelEp.TabIndex = 4;
            this.labelEp.Text = "labelEp";
            // 
            // backgroundWorkerDict
            // 
            this.backgroundWorkerDict.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDict_DoWork);
            this.backgroundWorkerDict.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerDict_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 549);
            this.Controls.Add(this.labelEp);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.wordText);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelAbout);
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "mDict";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAbout;
        private MaterialSkin.Controls.MaterialFlatButton btnSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField wordText;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Label labelEp;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDict;
    }
}

