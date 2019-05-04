using System;
using System.Windows.Forms;

namespace BlobManager.WinForms.Controls
{
	public class FileListViewItem : ListViewItem
	{
		public FileListViewItem(string localPath)
		{
			Path = localPath;
			Text = System.IO.Path.GetFileName(localPath);
		}

		public string Path { get; set; }

		private DateTime? _dateModified;
		public DateTime? DateModified
		{
			get { return _dateModified; }
			set { _dateModified = value; SubItems.Add(new ListViewSubItem() { Name = nameof(DateModified), Text = value.ToString() }); }
		}

		private long _size;
		public long Size
		{
			get { return _size; }
			set { _size = value; SubItems.Add(new ListViewSubItem() { Name = nameof(Size), Text = BytesToString(value) }); }
		}

		/// <summary>
		/// thanks to https://stackoverflow.com/a/4975942/2023653
		/// </summary>
		private static string BytesToString(long byteCount)
		{
			string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
			if (byteCount == 0) return "0" + suf[0];
			long bytes = Math.Abs(byteCount);
			int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
			double num = Math.Round(bytes / Math.Pow(1024, place), 1);
			return (Math.Sign(byteCount) * num).ToString() + " " + suf[place];
		}
		
	}
}