using BlobManager.WinForms.Models;
using BlobManager.WinForms.Services;
using JsonSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Library.Models;

namespace BlobManager.WinForms
{
	public partial class frmMain : Form
	{
		private AppSettings _settings;
		private string _currentPath;
		private StorageAccount _currentAccount;

		public frmMain()
		{
			InitializeComponent();
		}

		private void selectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dlg = new FolderBrowserDialog();
			if (dlg.ShowDialog() == DialogResult.OK) LoadLocalFiles(dlg.SelectedPath);
		}

		private void LoadLocalFiles(string path)
		{
			_currentPath = path;
			ddbLocalPath.Text = path;

			if (_settings.LocalPaths == null) _settings.LocalPaths = new HashSet<string>();
			_settings.LocalPaths.Add(path);

			fgvLocal.Clear();			
			var items = FileItem.FromLocalPath(path);
			fgvLocal.AddRange(items);
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			try
			{
                fgvLocal.SizingGrip = false;

				_settings = JsonSettingsBase.Load<AppSettings>();
				_settings.FormPosition?.Apply(this);
				FillLocalPathMenu();
				FillStorageAccountMenu();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private void FillStorageAccountMenu()
		{
			if (_settings.StrorageAccounts?.Any() ?? false)
			{
				toolStripSeparator2.Visible = true;
				foreach (var account in _settings.StrorageAccounts)
				{
					var button = new ToolStripButton() { Text = account.Name, Width = 300 };
					button.Click += async delegate (object senderInner, EventArgs eInner) { await LoadContainersAsync(account.Name, account.Key); };
					ddbStorageAccount.DropDownItems.Insert(0, button);
				}
			}
		}

		private void FillLocalPathMenu()
		{
			if (_settings.LocalPaths?.Any() ?? false)
			{
				toolStripSeparator1.Visible = true;
				foreach (var path in _settings.LocalPaths)
				{
					var button = new ToolStripButton() { Text = path, Width = 300 };
					button.Click += delegate (object senderInner, EventArgs eInner) { LoadLocalFiles(path); };
					ddbLocalPath.DropDownItems.Insert(0, button);
				}
			}
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			_settings.FormPosition = FormPosition.FromForm(this);
			_settings.Save();
		}

		private async void selectToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmStorageAccount dlg = new frmStorageAccount();
			if (dlg.ShowDialog() == DialogResult.OK) await LoadContainersAsync(dlg.AccountName, dlg.AccountKey);			
		}

		private async Task LoadContainersAsync(string accountName, string accountKey)
        {
            _currentAccount = new StorageAccount() { Name = accountName, Key = accountKey };

            ddbStorageAccount.Text = accountName;

            if (_settings.StrorageAccounts == null) _settings.StrorageAccounts = new HashSet<StorageAccount>();
            _settings.StrorageAccounts.Add(new StorageAccount() { Name = accountName, Key = accountKey });

            await LoadContainersInnerAsync();
        }

        private async Task LoadContainersInnerAsync()
        {
            fgvRemote.Clear();

            var storage = new BlobStorage(_currentAccount);
            var containers = await storage.ListContainersAsync();

            cbContainer.Items.Clear();
            cbContainer.Items.AddRange(containers.ToArray());
        }

        private async void cbContainer_SelectedIndexChanged(object sender, EventArgs e)
		{
			var storage = new BlobStorage(_currentAccount);
			string containerName = cbContainer.SelectedItem as string;
			var items = await storage.ListBlobsAsync(containerName);
			fgvRemote.Clear();
			fgvRemote.AddRange(items);
		}

        private async void BtnAddContainer_Click(object sender, EventArgs e)
        {
            var dlg = new frmNewContainer();
            dlg.StorageAccount = _currentAccount;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                await LoadContainersInnerAsync();
                cbContainer.SelectedItem = dlg.ContainerName;
            }
        }

        private void uploadHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2Collapsed = !splitContainer2.Panel2Collapsed;
            uploadHistoryToolStripMenuItem.Checked = !splitContainer2.Panel2Collapsed;
        }
    }
}