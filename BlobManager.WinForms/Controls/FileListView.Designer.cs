namespace BlobManager.WinForms.Controls
{
	partial class FileListView
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.imlSmallIcons = new System.Windows.Forms.ImageList(this.components);
			this.lvFiles = new System.Windows.Forms.ListView();
			this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// imlSmallIcons
			// 
			this.imlSmallIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imlSmallIcons.ImageSize = new System.Drawing.Size(16, 16);
			this.imlSmallIcons.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lvFiles
			// 
			this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colDateModified,
            this.colSize});
			this.lvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvFiles.Location = new System.Drawing.Point(0, 0);
			this.lvFiles.Name = "lvFiles";
			this.lvFiles.Size = new System.Drawing.Size(556, 204);
			this.lvFiles.TabIndex = 0;
			this.lvFiles.UseCompatibleStateImageBehavior = false;
			this.lvFiles.View = System.Windows.Forms.View.Details;
			// 
			// colName
			// 
			this.colName.Text = "Name";
			this.colName.Width = 205;
			// 
			// colDateModified
			// 
			this.colDateModified.Text = "Date Modified";
			this.colDateModified.Width = 116;
			// 
			// colSize
			// 
			this.colSize.Text = "Size";
			this.colSize.Width = 109;
			// 
			// FileListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lvFiles);
			this.Name = "FileListView";
			this.Size = new System.Drawing.Size(556, 204);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ImageList imlSmallIcons;
		private System.Windows.Forms.ListView lvFiles;
		private System.Windows.Forms.ColumnHeader colName;
		private System.Windows.Forms.ColumnHeader colDateModified;
		private System.Windows.Forms.ColumnHeader colSize;
	}
}
