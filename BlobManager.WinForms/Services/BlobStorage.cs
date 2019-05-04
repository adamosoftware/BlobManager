using BlobManager.WinForms.Models;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlobManager.WinForms.Services
{
	public class BlobStorage
	{
		private readonly string _accountName;
		private readonly string _accountKey;

		public BlobStorage(StorageAccount account)
		{
			_accountName = account.Name;
			_accountKey = account.Key;
		}

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

		public async Task<IEnumerable<FileItem>> ListBlobsAsync(string containerName)
		{
			var account = new CloudStorageAccount(new StorageCredentials(_accountName, _accountKey), true);
			var client = account.CreateCloudBlobClient();
			var token = new BlobContinuationToken();
			var container = client.GetContainerReference(containerName);
			if (!(await container.ExistsAsync())) throw new ArgumentException($"Container {container} does not exist in account {_accountName}.");

			List<FileItem> results = new List<FileItem>();
			do
			{
				var response = await container.ListBlobsSegmentedAsync(token);
				token = response.ContinuationToken;

				results.AddRange(response.Results.OfType<CloudBlobDirectory>().Select(dir => new FileItem()
				{
					ItemType = FileItemType.Folder,
					Path = dir.Uri.ToString(),
					NameGetter = (path) => 
					{
						var folders = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
						return folders.Last();
					}
				}));

				results.AddRange(response.Results.OfType<CloudBlockBlob>().Select(blob => new FileItem()
				{
					ItemType = FileItemType.File,
					Path = blob.Uri.ToString(),
					DateModified = blob.Properties.LastModified?.DateTime,
					Length = blob.Properties.Length,
					Type = blob.Properties.ContentType
				}));

			} while (token != null);

			return results;
		}
	}
}