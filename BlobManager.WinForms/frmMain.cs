using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BlobManager.WinForms
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dlg = new FolderBrowserDialog();
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				var folders = Directory.GetDirectories(dlg.SelectedPath);
				fileGridView1.AddRange(folders.Select(f =>
				{
					return new Models.FileItem()
					{
						ItemType = Models.FileItemType.Folder,
						Path = f
					};
				}));

				var files = Directory.GetFiles(dlg.SelectedPath);
				fileGridView1.AddRange(files.Select(f =>
				{
					FileInfo fi = new FileInfo(f);
					return new Models.FileItem()
					{
						Path = f,
						Length = fi.Length,
						DateModified = fi.LastWriteTime
					};
				}));

				

			}
		}
	}
}