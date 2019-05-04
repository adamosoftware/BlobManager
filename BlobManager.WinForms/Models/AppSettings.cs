using JsonSettings;
using System.Collections.Generic;
using System.Security.Cryptography;
using WinForms.Library.Models;

namespace BlobManager.WinForms.Models
{
	public class AppSettings : JsonSettingsBase
	{
		public FormPosition FormPosition { get; set; }
		public HashSet<string> LocalPaths { get; set; } = new HashSet<string>();
		public HashSet<StorageAccount> StrorageAccounts { get; set; } = new HashSet<StorageAccount>();

		public override Scope Scope => Scope.User;
		public override string CompanyName => "Adam O'Neil Software";
		public override string ProductName => "Azure Uploader";
		public override string Filename => "Settings.json";
	}

	public class StorageAccount
	{
		[JsonProtect(DataProtectionScope.CurrentUser)]
		public string Name { get; set; }

		[JsonProtect(DataProtectionScope.CurrentUser)]
		public string Key { get; set; }

		public override bool Equals(object obj)
		{
			StorageAccount test = obj as StorageAccount;
			if (test != null)
			{
				return test.Name.ToLower().Equals(Name.ToLower());
			}
			return false;
		}

		public override int GetHashCode()
		{
			return Name.ToLower().GetHashCode();
		}
	}
}