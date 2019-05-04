using JsonSettings;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace BlobManager.WinForms.Services
{
	public class Uploader
	{
		/// <summary>
		/// Local folder where files are uploaded from
		/// </summary>
		public string SourceFolder { get; set; }

		[JsonProtect(DataProtectionScope.CurrentUser)]
		public string TargetAccountName { get; set; }

		[JsonProtect(DataProtectionScope.CurrentUser)]
		public string TargetAccountKey { get; set; }

		[JsonProtect(DataProtectionScope.CurrentUser)]
		public string TargetContainer { get; set; }


		public async Task UploadFilesAsync()
		{

		}
	}
}