using System;

namespace BlobManager.WinForms.Interfaces
{
	public interface IFileItem
	{
		string Name { get; }
		string Path { get; set; }
		DateTime DateCreated { get; set; }
		DateTime DateModified { get; set; }
		long Length { get; set; }
	}
}