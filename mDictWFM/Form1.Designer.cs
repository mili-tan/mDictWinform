﻿namespace mDictWFM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelAbout = new System.Windows.Forms.Label();
            this.btnSearch = new MaterialSkin.Controls.MaterialFlatButton();
            this.wordText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelWord = new System.Windows.Forms.Label();
            this.labelEp = new System.Windows.Forms.Label();
            this.backgroundWorkerBingDict = new System.ComponentModel.BackgroundWorker();
            this.Divider1 = new MaterialSkin.Controls.MaterialDivider();
            this.labelPos1 = new System.Windows.Forms.Label();
            this.Divider2 = new MaterialSkin.Controls.MaterialDivider();
            this.labelMn1 = new System.Windows.Forms.Label();
            this.labelMn2 = new System.Windows.Forms.Label();
            this.labelPos2 = new System.Windows.Forms.Label();
            this.labelMn3 = new System.Windows.Forms.Label();
            this.labelPos3 = new System.Windows.Forms.Label();
            this.labelMn4 = new System.Windows.Forms.Label();
            this.labelPos4 = new System.Windows.Forms.Label();
            this.backgroundWorkerYoodaoDict = new System.ComponentModel.BackgroundWorker();
            this.timerTip = new System.Windows.Forms.Timer(this.components);
            this.windowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnCopy = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSpeech = new MaterialSkin.Controls.MaterialFlatButton();
            this.backgroundWorkerSpeech = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAbout
            // 
            this.labelAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAbout.AutoEllipsis = true;
            this.labelAbout.BackColor = System.Drawing.Color.Transparent;
            this.labelAbout.Font = new System.Drawing.Font("Noto Sans CJK SC Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAbout.ForeColor = System.Drawing.Color.Silver;
            this.labelAbout.Location = new System.Drawing.Point(-2, 444);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(734, 36);
            this.labelAbout.TabIndex = 0;
            this.labelAbout.Text = "数据来源 : Bing / Youdao";
            this.labelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.AutoSize = true;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Depth = 0;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(663, 77);
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
            this.wordText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordText.Depth = 0;
            this.wordText.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.wordText.Hint = "输入你想要查询的单词";
            this.wordText.Location = new System.Drawing.Point(12, 80);
            this.wordText.MaxLength = 32767;
            this.wordText.MouseState = MaterialSkin.MouseState.HOVER;
            this.wordText.Name = "wordText";
            this.wordText.PasswordChar = '\0';
            this.wordText.SelectedText = "";
            this.wordText.SelectionLength = 0;
            this.wordText.SelectionStart = 0;
            this.wordText.Size = new System.Drawing.Size(644, 33);
            this.wordText.TabIndex = 2;
            this.wordText.TabStop = false;
            this.wordText.UseSystemPasswordChar = false;
            this.wordText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wordText_KeyDown);
            // 
            // labelWord
            // 
            this.labelWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Noto Sans CJK SC Regular", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelWord.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelWord.Location = new System.Drawing.Point(5, 122);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(33, 56);
            this.labelWord.TabIndex = 3;
            this.labelWord.Text = " ";
            // 
            // labelEp
            // 
            this.labelEp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEp.AutoSize = true;
            this.labelEp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEp.Location = new System.Drawing.Point(13, 178);
            this.labelEp.Name = "labelEp";
            this.labelEp.Size = new System.Drawing.Size(12, 18);
            this.labelEp.TabIndex = 4;
            this.labelEp.Text = " ";
            // 
            // backgroundWorkerBingDict
            // 
            this.backgroundWorkerBingDict.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerBingDict_DoWork);
            this.backgroundWorkerBingDict.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerBingDict_RunWorkerCompleted);
            // 
            // Divider1
            // 
            this.Divider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Divider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Divider1.Depth = 0;
            this.Divider1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Divider1.Location = new System.Drawing.Point(0, 444);
            this.Divider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Divider1.Name = "Divider1";
            this.Divider1.Size = new System.Drawing.Size(734, 1);
            this.Divider1.TabIndex = 5;
            this.Divider1.Text = "materialDivider1";
            // 
            // labelPos1
            // 
            this.labelPos1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPos1.AutoEllipsis = true;
            this.labelPos1.Font = new System.Drawing.Font("Noto Sans CJK SC Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPos1.Location = new System.Drawing.Point(12, 230);
            this.labelPos1.Name = "labelPos1";
            this.labelPos1.Size = new System.Drawing.Size(706, 21);
            this.labelPos1.TabIndex = 6;
            this.labelPos1.Tag = "";
            this.labelPos1.Text = " ";
            // 
            // Divider2
            // 
            this.Divider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Divider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Divider2.Depth = 0;
            this.Divider2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Divider2.Location = new System.Drawing.Point(-2, 222);
            this.Divider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Divider2.Name = "Divider2";
            this.Divider2.Size = new System.Drawing.Size(734, 1);
            this.Divider2.TabIndex = 7;
            this.Divider2.Text = "materialDivider2";
            // 
            // labelMn1
            // 
            this.labelMn1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMn1.AutoEllipsis = true;
            this.labelMn1.Font = new System.Drawing.Font("Noto Sans CJK SC Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMn1.Location = new System.Drawing.Point(10, 251);
            this.labelMn1.Name = "labelMn1";
            this.labelMn1.Size = new System.Drawing.Size(710, 30);
            this.labelMn1.TabIndex = 8;
            this.labelMn1.Text = " ";
            // 
            // labelMn2
            // 
            this.labelMn2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMn2.AutoEllipsis = true;
            this.labelMn2.Font = new System.Drawing.Font("Noto Sans CJK SC Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMn2.Location = new System.Drawing.Point(10, 302);
            this.labelMn2.Name = "labelMn2";
            this.labelMn2.Size = new System.Drawing.Size(710, 30);
            this.labelMn2.TabIndex = 10;
            this.labelMn2.Text = " ";
            // 
            // labelPos2
            // 
            this.labelPos2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPos2.AutoEllipsis = true;
            this.labelPos2.Font = new System.Drawing.Font("Noto Sans CJK SC Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPos2.Location = new System.Drawing.Point(12, 281);
            this.labelPos2.Name = "labelPos2";
            this.labelPos2.Size = new System.Drawing.Size(706, 21);
            this.labelPos2.TabIndex = 9;
            this.labelPos2.Text = " ";
            // 
            // labelMn3
            // 
            this.labelMn3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMn3.AutoEllipsis = true;
            this.labelMn3.Font = new System.Drawing.Font("Noto Sans CJK SC Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMn3.Location = new System.Drawing.Point(10, 353);
            this.labelMn3.Name = "labelMn3";
            this.labelMn3.Size = new System.Drawing.Size(710, 30);
            this.labelMn3.TabIndex = 12;
            this.labelMn3.Text = " ";
            // 
            // labelPos3
            // 
            this.labelPos3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPos3.AutoEllipsis = true;
            this.labelPos3.Font = new System.Drawing.Font("Noto Sans CJK SC Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPos3.Location = new System.Drawing.Point(12, 332);
            this.labelPos3.Name = "labelPos3";
            this.labelPos3.Size = new System.Drawing.Size(706, 21);
            this.labelPos3.TabIndex = 11;
            this.labelPos3.Text = " ";
            // 
            // labelMn4
            // 
            this.labelMn4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMn4.AutoEllipsis = true;
            this.labelMn4.Font = new System.Drawing.Font("Noto Sans CJK SC Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMn4.Location = new System.Drawing.Point(10, 404);
            this.labelMn4.Name = "labelMn4";
            this.labelMn4.Size = new System.Drawing.Size(708, 30);
            this.labelMn4.TabIndex = 14;
            this.labelMn4.Text = " ";
            // 
            // labelPos4
            // 
            this.labelPos4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPos4.AutoEllipsis = true;
            this.labelPos4.Font = new System.Drawing.Font("Noto Sans CJK SC Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPos4.Location = new System.Drawing.Point(12, 383);
            this.labelPos4.Name = "labelPos4";
            this.labelPos4.Size = new System.Drawing.Size(706, 21);
            this.labelPos4.TabIndex = 13;
            this.labelPos4.Text = " ";
            // 
            // backgroundWorkerYoodaoDict
            // 
            this.backgroundWorkerYoodaoDict.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerYoodaoDict_DoWork);
            this.backgroundWorkerYoodaoDict.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerYoodaoDict_RunWorkerCompleted);
            // 
            // timerTip
            // 
            this.timerTip.Enabled = true;
            this.timerTip.Interval = 500;
            this.timerTip.Tick += new System.EventHandler(this.timerTip_Tick);
            // 
            // windowsMediaPlayer
            // 
            this.windowsMediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowsMediaPlayer.Enabled = true;
            this.windowsMediaPlayer.Location = new System.Drawing.Point(509, 122);
            this.windowsMediaPlayer.Name = "windowsMediaPlayer";
            this.windowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMediaPlayer.OcxState")));
            this.windowsMediaPlayer.Size = new System.Drawing.Size(209, 44);
            this.windowsMediaPlayer.TabIndex = 16;
            this.windowsMediaPlayer.Visible = false;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.AutoSize = true;
            this.btnCopy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopy.Depth = 0;
            this.btnCopy.Icon = global::mDictWFM.Properties.Resources.copy;
            this.btnCopy.Location = new System.Drawing.Point(601, 175);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCopy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Primary = false;
            this.btnCopy.Size = new System.Drawing.Size(119, 36);
            this.btnCopy.TabIndex = 17;
            this.btnCopy.Text = "复制释义";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnSpeech
            // 
            this.btnSpeech.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpeech.AutoSize = true;
            this.btnSpeech.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSpeech.Depth = 0;
            this.btnSpeech.Icon = global::mDictWFM.Properties.Resources.text_to_speech;
            this.btnSpeech.Location = new System.Drawing.Point(509, 175);
            this.btnSpeech.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSpeech.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSpeech.Name = "btnSpeech";
            this.btnSpeech.Primary = false;
            this.btnSpeech.Size = new System.Drawing.Size(84, 36);
            this.btnSpeech.TabIndex = 15;
            this.btnSpeech.Text = "朗读";
            this.btnSpeech.UseVisualStyleBackColor = true;
            this.btnSpeech.Click += new System.EventHandler(this.btnSpeech_Click);
            // 
            // backgroundWorkerSpeech
            // 
            this.backgroundWorkerSpeech.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSpeech_DoWork);
            this.backgroundWorkerSpeech.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSpeech_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 480);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.windowsMediaPlayer);
            this.Controls.Add(this.btnSpeech);
            this.Controls.Add(this.labelMn4);
            this.Controls.Add(this.labelPos4);
            this.Controls.Add(this.labelMn3);
            this.Controls.Add(this.labelPos3);
            this.Controls.Add(this.labelMn2);
            this.Controls.Add(this.labelPos2);
            this.Controls.Add(this.labelMn1);
            this.Controls.Add(this.Divider2);
            this.Controls.Add(this.labelPos1);
            this.Controls.Add(this.Divider1);
            this.Controls.Add(this.labelEp);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.wordText);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelAbout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mDict";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAbout;
        private MaterialSkin.Controls.MaterialFlatButton btnSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField wordText;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Label labelEp;
        private System.ComponentModel.BackgroundWorker backgroundWorkerBingDict;
        private MaterialSkin.Controls.MaterialDivider Divider1;
        private System.Windows.Forms.Label labelPos1;
        private MaterialSkin.Controls.MaterialDivider Divider2;
        private System.Windows.Forms.Label labelMn1;
        private System.Windows.Forms.Label labelMn2;
        private System.Windows.Forms.Label labelPos2;
        private System.Windows.Forms.Label labelMn3;
        private System.Windows.Forms.Label labelPos3;
        private System.Windows.Forms.Label labelMn4;
        private System.Windows.Forms.Label labelPos4;
        private System.ComponentModel.BackgroundWorker backgroundWorkerYoodaoDict;
        private System.Windows.Forms.Timer timerTip;
        private MaterialSkin.Controls.MaterialFlatButton btnSpeech;
        private AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer;
        private MaterialSkin.Controls.MaterialFlatButton btnCopy;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSpeech;
    }
}

