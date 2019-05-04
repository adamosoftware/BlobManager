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
			this.btnSelectLocalFolder = new System.Windows.Forms.ToolStripButton();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.tslLocalPath = new System.Windows.Forms.ToolStripLabel();
			this.fgvLocal = new BlobManager.WinForms.Controls.FileGridView();
			this.fgvRemote = new BlobManager.WinForms.Controls.FileGridView();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
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
			this.splitContainer1.Size = new System.Drawing.Size(773, 357);
			this.splitContainer1.SplitterDistance = 384;
			this.splitContainer1.TabIndex = 0;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslLocalPath,
            this.btnSelectLocalFolder});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(384, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnSelectLocalFolder
			// 
			this.btnSelectLocalFolder.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnSelectLocalFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnSelectLocalFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectLocalFolder.Image")));
			this.btnSelectLocalFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSelectLocalFolder.Name = "btnSelectLocalFolder";
			this.btnSelectLocalFolder.Size = new System.Drawing.Size(51, 22);
			this.btnSelectLocalFolder.Text = "Select...";
			this.btnSelectLocalFolder.Click += new System.EventHandler(this.btnSelectLocalFolder_Click);
			// 
			// toolStrip2
			// 
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(385, 25);
			this.toolStrip2.TabIndex = 0;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// tslLocalPath
			// 
			this.tslLocalPath.Name = "tslLocalPath";
			this.tslLocalPath.Size = new System.Drawing.Size(59, 22);
			this.tslLocalPath.Text = "local path";
			// 
			// fgvLocal
			// 
			this.fgvLocal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgvLocal.Location = new System.Drawing.Point(0, 25);
			this.fgvLocal.Name = "fgvLocal";
			this.fgvLocal.Size = new System.Drawing.Size(384, 332);
			this.fgvLocal.TabIndex = 0;
			// 
			// fgvRemote
			// 
			this.fgvRemote.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgvRemote.Location = new System.Drawing.Point(0, 25);
			this.fgvRemote.Name = "fgvRemote";
			this.fgvRemote.Size = new System.Drawing.Size(385, 332);
			this.fgvRemote.TabIndex = 1;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(773, 357);
			this.Controls.Add(this.splitContainer1);
			this.Name = "frmMain";
			this.Text = "Form1";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private Controls.FileGridView fgvLocal;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnSelectLocalFolder;
		private Controls.FileGridView fgvRemote;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripLabel tslLocalPath;
	}
}

