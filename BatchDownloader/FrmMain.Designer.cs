namespace BatchDownloader
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.lstUrl = new System.Windows.Forms.ListBox();
            this.rtxLog = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.nuTaskNum = new System.Windows.Forms.NumericUpDown();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.btnPage = new System.Windows.Forms.Button();
            this.lblExt = new System.Windows.Forms.Label();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuTaskNum)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(10, 17);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUrl.Size = new System.Drawing.Size(57, 130);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "URL Page\r\n\r\n\r\nURL File\r\n\r\n\r\nSave Path\r\n\r\n\r\nTasks";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(73, 53);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(361, 20);
            this.txtFile.TabIndex = 9;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(73, 92);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(361, 20);
            this.txtPath.TabIndex = 10;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(359, 128);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 6;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(440, 51);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 23);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "Open File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lstUrl
            // 
            this.lstUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstUrl.Location = new System.Drawing.Point(10, 168);
            this.lstUrl.Name = "lstUrl";
            this.lstUrl.Size = new System.Drawing.Size(505, 420);
            this.lstUrl.TabIndex = 11;
            // 
            // rtxLog
            // 
            this.rtxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxLog.Location = new System.Drawing.Point(521, 12);
            this.rtxLog.Name = "rtxLog";
            this.rtxLog.Size = new System.Drawing.Size(454, 576);
            this.rtxLog.TabIndex = 12;
            this.rtxLog.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(440, 128);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // nuTaskNum
            // 
            this.nuTaskNum.Location = new System.Drawing.Point(73, 131);
            this.nuTaskNum.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nuTaskNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuTaskNum.Name = "nuTaskNum";
            this.nuTaskNum.Size = new System.Drawing.Size(40, 20);
            this.nuTaskNum.TabIndex = 4;
            this.nuTaskNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(440, 90);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 3;
            this.btnPath.Text = "Save Path";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(73, 14);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(361, 20);
            this.txtPage.TabIndex = 8;
            // 
            // btnPage
            // 
            this.btnPage.Location = new System.Drawing.Point(440, 12);
            this.btnPage.Name = "btnPage";
            this.btnPage.Size = new System.Drawing.Size(75, 23);
            this.btnPage.TabIndex = 1;
            this.btnPage.Text = "Open Page";
            this.btnPage.UseVisualStyleBackColor = true;
            this.btnPage.Click += new System.EventHandler(this.btnOpenPage_Click);
            // 
            // lblExt
            // 
            this.lblExt.AutoSize = true;
            this.lblExt.Location = new System.Drawing.Point(119, 134);
            this.lblExt.Name = "lblExt";
            this.lblExt.Size = new System.Drawing.Size(53, 13);
            this.lblExt.TabIndex = 16;
            this.lblExt.Text = "Extension";
            // 
            // txtExt
            // 
            this.txtExt.Location = new System.Drawing.Point(178, 130);
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(94, 20);
            this.txtExt.TabIndex = 5;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(278, 128);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 17;
            this.btnList.Text = "Save List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(987, 598);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtExt);
            this.Controls.Add(this.lblExt);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.nuTaskNum);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rtxLog);
            this.Controls.Add(this.lstUrl);
            this.Controls.Add(this.btnPage);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.lblUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Batch Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.nuTaskNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.ListBox lstUrl;
        private System.Windows.Forms.RichTextBox rtxLog;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NumericUpDown nuTaskNum;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Button btnPage;
        private System.Windows.Forms.Label lblExt;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.Button btnList;
    }
}