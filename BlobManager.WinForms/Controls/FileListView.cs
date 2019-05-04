using System.Windows.Forms;
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
			AddRange(new FileListViewItem[] { fileItem });
		}

		public void AddRange(FileListViewItem[] fileItems)
		{
			lvFiles.Items.AddRange(fileItems);
			foreach (var item in fileItems) item.ImageKey = AddIcon(imlSmallIcons, item.Path, IconSize.Small);
		}
	}
}