using System;
using System.Drawing;

namespace BlobManager.WinForms.Models
{
	public enum FileItemType
	{
		Folder,
		File
	}

	public class FileItem
	{
		public FileItemType ItemType { get; set; } = FileItemType.File;
		public bool IsSelected { get; set; }
		public string Path { get; set; }
		public string Name { get { return System.IO.Path.GetFileName(Path); } }
		public Image Icon { get; set; }
		public DateTime DateModified { get; set; }
		public string Type { get; set; }
		public long Length { get; set; }		
		public string SizeText { get { return BytesToString(Length); } }

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