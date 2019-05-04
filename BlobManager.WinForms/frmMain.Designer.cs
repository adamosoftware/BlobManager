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
			this.fileListView1 = new BlobManager.WinForms.Controls.FileListView();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// fileListView1
			// 
			this.fileListView1.Location = new System.Drawing.Point(119, 96);
			this.fileListView1.Name = "fileListView1";
			this.fileListView1.Size = new System.Drawing.Size(556, 288);
			this.fileListView1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(128, 43);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.fileListView1);
			this.Name = "frmMain";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.FileListView fileListView1;
		private System.Windows.Forms.Button button1;
	}
}

