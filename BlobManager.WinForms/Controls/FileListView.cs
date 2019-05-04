using System.Windows.Forms;
using WinForms.Library;
using static WinForms.Library.FileSystem;

namespace BlobManager.WinForms.Controls
{
	public partial class FileListView : UserControl
	{
		public FileListView()
		{
			InitializeComponent();
			lvFiles.SmallImageList = imlSmallIcons;
		}

		public void Add(FileListViewItem fileItem)
		{
			var item = lvFiles.Items.Add(fileItem);
			item.ImageKey = FileSystem.AddIcon(imlSmallIcons, fileItem.Path, IconSize.Small);
			
		}

		public void AddRange(FileListViewItem[] fileItems)
		{
			lvFiles.Items.AddRange(fileItems);
			foreach (var item in fileItems) item.ImageKey = AddIcon(imlSmallIcons, item.Path, IconSize.Small);
		}
	}
}