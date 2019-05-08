using BlobManager.WinForms.Models;
using BlobManager.WinForms.Services;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinForms.Library.Extensions;

namespace BlobManager.WinForms
{
    public partial class frmNewContainer : Form
    {
        public frmNewContainer()
        {
            InitializeComponent();
        }

        public StorageAccount StorageAccount { get; set; }

        public string ContainerName {  get { return tbName.Text; } }

        private async void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                var storage = new BlobStorage(StorageAccount);
                await storage.CreateContainerAsync(tbName.Text, cbPermissions.GetValue<BlobContainerPublicAccessType>());
                DialogResult = DialogResult.OK;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void frmNewContainer_Load(object sender, EventArgs e)
        {
            cbPermissions.Fill(new Dictionary<BlobContainerPublicAccessType, string>()
            {
                { BlobContainerPublicAccessType.Off, "Private - access by account owner only" },
                { BlobContainerPublicAccessType.Container, "Container - public read access for containers and blobs" },
                { BlobContainerPublicAccessType.Blob, "Blob - public read access for blobs" }
            });
        }
    }
}
