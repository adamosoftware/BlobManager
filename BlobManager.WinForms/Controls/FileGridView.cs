using BlobManager.WinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WinForms.Library;

namespace BlobManager.WinForms.Controls
{
	public partial class FileGridView : UserControl
	{
		private BindingList<FileItem> _files = null;

		public FileGridView()
		{
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			Clear();
		}

		public void Clear()
		{
			_files = new BindingList<FileItem>();
			dataGridView1.DataSource = _files;
			_files.ListChanged += files_ListChanged;
		}

		private void files_ListChanged(object sender, ListChangedEventArgs e)
		{
			int folderCount = _files.Count(item => item.ItemType == FileItemType.Folder);
			int fileCount = _files.Count(item => item.ItemType == FileItemType.File);
			tslFileCount.Text = $"{folderCount} folders, {fileCount} files";
		}

		public event EventHandler ItemSelected;

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

		public FileItem SelectedItem { get; private set; }

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var item = dataGridView1.Rows[e.RowIndex].DataBoundItem as FileItem;
			if (item != null)
			{
				SelectedItem = item;
				ItemSelected?.Invoke(item, new EventArgs());
			}
		}
	}
}