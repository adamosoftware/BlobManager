using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlobManager.WinForms.Services
{
	public class BlobStorage
	{
		private readonly string _accountName;
		private readonly string _accountKey;

		public BlobStorage(string accountName, string accountKey)
		{
			_accountName = accountName;
			_accountKey = accountKey;
		}

		public async Task<IEnumerable<string>> ListContainersAsync()
		{
			var account = new CloudStorageAccount(new StorageCredentials(_accountName, _accountKey), true);
			var client = account.CreateCloudBlobClient();
			var token = new BlobContinuationToken();

			List<string> results = new List<string>();
			do
			{
				var response = await client.ListContainersSegmentedAsync(token);
				token = response.ContinuationToken;
				results.AddRange(response.Results.Select(c => c.Name));
			} while (token != null);

			return results;
		}
	}
}