using BlobManager.WinForms.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using WinForms.Library;

namespace BlobManager.WinForms.Controls
{
	public partial class FileGridView : UserControl
	{
		private BindingList<FileItem> _files = new BindingList<FileItem>();

		public FileGridView()
		{
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.DataSource = _files;
		}

		public void AddRange(IEnumerable<FileItem> files)
		{
			foreach (var item in files)
			{
				_files.Add(item);
				switch (item.ItemType)
				{
					case FileItemType.File:
						string ext = FileSystem.AddIcon(imlSmallIcons, item.Path, FileSystem.IconSize.Small);
						item.Icon = imlSmallIcons.Images[ext];
						break;

					case FileItemType.Folder:
						item.Icon = imlSmallIcons.Images["folder"];
						break;
				}
				
			}
		}
	}
}