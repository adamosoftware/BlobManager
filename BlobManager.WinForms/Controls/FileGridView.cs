using BlobManager.WinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WinForms.Library;

namespace BlobManager.WinForms.Controls
{
    public delegate FileItem FileReceivedHandler(string localFile);

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
            UpdateStatusBar();
		}

		private void files_ListChanged(object sender, ListChangedEventArgs e)
        {
            UpdateStatusBar();
        }

        private void UpdateStatusBar()
        {
            int folderCount = _files.Count(item => item.ItemType == FileItemType.Folder);
            int fileCount = _files.Count(item => item.ItemType == FileItemType.File);
            tslFileCount.Text = $"{folderCount} folders, {fileCount} files";
        }

        public event EventHandler ItemSelected;
        public event FileReceivedHandler FileReceived;           

        public void Add(FileItem file)
        {
            AddRange(new FileItem[] { file });
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

        [Browsable(false)]
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

        [Browsable(true)]
        public bool SizingGrip
        {
            get { return statusStrip1.SizingGrip; }
            set { statusStrip1.SizingGrip = value; }
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                try
                {
                    toolStripProgressBar1.Visible = true;
                    toolStripProgressBar1.Maximum = files.Length;
                    foreach (var file in files)
                    {
                        tslFileCount.Text = System.IO.Path.GetFileName(file);
                        toolStripProgressBar1.Value++;
                        var item = FileReceived?.Invoke(file); // do your upload or local copy here
                        if (item != null) Add(item);                        
                    }                    
                }
                finally
                {
                    UpdateStatusBar();
                    toolStripProgressBar1.Visible = false;
                }                                
            }
        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            // thanks to https://stackoverflow.com/q/11143981/2023653

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }            
        }
    }
}