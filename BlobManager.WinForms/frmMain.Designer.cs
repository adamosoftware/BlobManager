namespace BlobManager.WinForms
{
	partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ddbLocalPath = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ddbStorageAccount = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbContainer = new System.Windows.Forms.ToolStripComboBox();
            this.btnAddContainer = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendingUploadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completedUploadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.fgvLocal = new BlobManager.WinForms.Controls.FileGridView();
            this.fgvRemote = new BlobManager.WinForms.Controls.FileGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fgvLocal);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.fgvRemote);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer1.Size = new System.Drawing.Size(906, 422);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddbLocalPath});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(450, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ddbLocalPath
            // 
            this.ddbLocalPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbLocalPath.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.selectToolStripMenuItem});
            this.ddbLocalPath.Image = ((System.Drawing.Image)(resources.GetObject("ddbLocalPath.Image")));
            this.ddbLocalPath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbLocalPath.Name = "ddbLocalPath";
            this.ddbLocalPath.Size = new System.Drawing.Size(75, 22);
            this.ddbLocalPath.Text = "Local Path";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            this.toolStripSeparator1.Visible = false;
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.selectToolStripMenuItem.Text = "Select...";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddbStorageAccount,
            this.cbContainer,
            this.btnAddContainer});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(452, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ddbStorageAccount
            // 
            this.ddbStorageAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbStorageAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.selectToolStripMenuItem1});
            this.ddbStorageAccount.Image = ((System.Drawing.Image)(resources.GetObject("ddbStorageAccount.Image")));
            this.ddbStorageAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbStorageAccount.Name = "ddbStorageAccount";
            this.ddbStorageAccount.Size = new System.Drawing.Size(108, 22);
            this.ddbStorageAccount.Text = "Storage Account";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(111, 6);
            this.toolStripSeparator2.Visible = false;
            // 
            // selectToolStripMenuItem1
            // 
            this.selectToolStripMenuItem1.Name = "selectToolStripMenuItem1";
            this.selectToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.selectToolStripMenuItem1.Text = "Select...";
            this.selectToolStripMenuItem1.Click += new System.EventHandler(this.selectToolStripMenuItem1_Click);
            // 
            // cbContainer
            // 
            this.cbContainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContainer.Name = "cbContainer";
            this.cbContainer.Size = new System.Drawing.Size(200, 25);
            this.cbContainer.SelectedIndexChanged += new System.EventHandler(this.cbContainer_SelectedIndexChanged);
            // 
            // btnAddContainer
            // 
            this.btnAddContainer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddContainer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddContainer.Image")));
            this.btnAddContainer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddContainer.Name = "btnAddContainer";
            this.btnAddContainer.Size = new System.Drawing.Size(99, 22);
            this.btnAddContainer.Text = "New Container...";
            this.btnAddContainer.Click += new System.EventHandler(this.BtnAddContainer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendingUploadsToolStripMenuItem,
            this.completedUploadsToolStripMenuItem,
            this.toolStripSeparator3,
            this.uploadHistoryToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.viewToolStripMenuItem.Text = "View Uploads";
            // 
            // pendingUploadsToolStripMenuItem
            // 
            this.pendingUploadsToolStripMenuItem.Name = "pendingUploadsToolStripMenuItem";
            this.pendingUploadsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pendingUploadsToolStripMenuItem.Text = "Pending";
            // 
            // completedUploadsToolStripMenuItem
            // 
            this.completedUploadsToolStripMenuItem.Name = "completedUploadsToolStripMenuItem";
            this.completedUploadsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.completedUploadsToolStripMenuItem.Text = "Completed";
            // 
            // uploadHistoryToolStripMenuItem
            // 
            this.uploadHistoryToolStripMenuItem.Name = "uploadHistoryToolStripMenuItem";
            this.uploadHistoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uploadHistoryToolStripMenuItem.Text = "History";
            this.uploadHistoryToolStripMenuItem.Click += new System.EventHandler(this.uploadHistoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 24);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel2Collapsed = true;
            this.splitContainer2.Size = new System.Drawing.Size(906, 422);
            this.splitContainer2.SplitterDistance = 266;
            this.splitContainer2.TabIndex = 2;
            // 
            // fgvLocal
            // 
            this.fgvLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgvLocal.Location = new System.Drawing.Point(0, 25);
            this.fgvLocal.Name = "fgvLocal";
            this.fgvLocal.Size = new System.Drawing.Size(450, 397);
            this.fgvLocal.TabIndex = 0;
            // 
            // fgvRemote
            // 
            this.fgvRemote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgvRemote.Location = new System.Drawing.Point(0, 25);
            this.fgvRemote.Name = "fgvRemote";
            this.fgvRemote.Size = new System.Drawing.Size(452, 397);
            this.fgvRemote.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 446);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Blob Uploader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private Controls.FileGridView fgvLocal;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private Controls.FileGridView fgvRemote;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripDropDownButton ddbLocalPath;
		private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripDropDownButton ddbStorageAccount;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem1;
		private System.Windows.Forms.ToolStripComboBox cbContainer;
        private System.Windows.Forms.ToolStripButton btnAddContainer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendingUploadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completedUploadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem uploadHistoryToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

