using BlobManager.WinForms.Models;
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

		private void btnSelectLocalFolder_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dlg = new FolderBrowserDialog();
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				fgvLocal.Clear();
				tslLocalPath.Text = dlg.SelectedPath;
				var items = FileItem.FromLocalPath(dlg.SelectedPath);
				fgvLocal.AddRange(items);
			}
		}
	}
}