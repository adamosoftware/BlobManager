using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlobManager.WinForms.Controls
{
	public class FileListViewItem : ListViewItem
	{
		public FileListViewItem(string path)
		{
			Path = path;
			Text = System.IO.Path.GetFileName(path);
		}

		public string Path { get; set; }
	}
}
